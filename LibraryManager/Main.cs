using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace LibraryManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void displayBookAt(int index, Book book)
        {
            if (dataGridView1.Rows.Count > index)
            {
                dataGridView1.Rows.RemoveAt(index);
            }
            dataGridView1.Rows.Insert(
                index,
                book.ID,
                book.Title,
                book.Author,
                book.Publisher,
                book.Year,
                book.Quality,
                book.Price,
                book.TakenSince,
                book.TakenSince == null ? "Give" : "Take Back");
        }

        private void displayAllBooks()
        {
            dataGridView1.Rows.Clear();
            if (BookManager.Main != null)
            {
                BookManager.Main.GetBooks().ForEach((book) =>
                {
                    displayBookAt(dataGridView1.Rows.Count, book);
                });
            }
        }

        private void displayBooksByName(string name)
        {
            dataGridView1.Rows.Clear();
            if (BookManager.Main != null)
            {
                BookManager.Main.FindBooksByTitle(name).ForEach((book) =>
                {
                    displayBookAt(dataGridView1.Rows.Count, book);
                });
            }
        }

        private void displayBooksByAuthor(string author)
        {
            dataGridView1.Rows.Clear();
            if (BookManager.Main != null)
            {
                BookManager.Main.FindBooksByAuthor(author).ForEach((book) =>
                {
                    displayBookAt(dataGridView1.Rows.Count, book);
                });
            }
        }

        private void displayBooksByPublisher(string publisher)
        {
            dataGridView1.Rows.Clear();
            if (BookManager.Main != null)
            {
                BookManager.Main.FindBooksByPublisher(publisher).ForEach((book) =>
                {
                    displayBookAt(dataGridView1.Rows.Count, book);
                });
            }
        }

        private void displayBooksByYears(int from, int to)
        {
            dataGridView1.Rows.Clear();
            if (BookManager.Main != null)
            {
                BookManager.Main.FindBooksByYears(from, to).ForEach((book) =>
                {
                    displayBookAt(dataGridView1.Rows.Count, book);
                });
            }
        }

        private void displayBooksByPrice(float min, float max)
        {
            dataGridView1.Rows.Clear();
            if (BookManager.Main != null)
            {
                BookManager.Main.FindBooksByPrice(min, max).ForEach((book) =>
                {
                    displayBookAt(dataGridView1.Rows.Count, book);
                });
            }
        }
        private void displayBooksByQuality(string quality)
        {
            dataGridView1.Rows.Clear();
            if (BookManager.Main != null)
            {
                BookManager.Main.FindBooksByQuality(quality).ForEach((book) =>
                {
                    displayBookAt(dataGridView1.Rows.Count, book);
                });
            }
        }

        private void addBook(string title, string author, string publisher, int year, string quality, float price)
        {
            if (BookManager.Main != null)
            {
                BookManager.Main.AddBook(title, author, publisher, year, quality, price);
                BookManager.Main.Save();
            }

            displayAllBooks();
        }

        private void generateBooks(int min, int max)
        {
            if (BookManager.Main != null)
            {
                BookManager.Main.GenerateBooks(min, max);
                BookManager.Main.Save();
            }

            displayAllBooks();
        }

        private void displayTakenBooks() {
            dataGridView1.Rows.Clear();
            if (BookManager.Main != null)
            {
                BookManager.Main.FindBooksTaken().ForEach((book) =>
                {
                    displayBookAt(dataGridView1.Rows.Count, book);
                });
            }
        }

        private void displayTakenMoreThanThreeMonthsAgoBooks()
        {
            dataGridView1.Rows.Clear();
            if (BookManager.Main != null)
            {
                DateTime date = DateTime.Today.AddMonths(-3);
                BookManager.Main.FindBooksTakenBefore(date).ForEach((book) =>
                {
                    displayBookAt(dataGridView1.Rows.Count, book);
                });
            }
        }

        private void displayAvailableBooks()
        {
            dataGridView1.Rows.Clear();
            if (BookManager.Main != null)
            {
                BookManager.Main.FindBooksAvailable().ForEach((book) =>
                {
                    displayBookAt(dataGridView1.Rows.Count, book);
                });
            }
        }

        private void updateBooksQualityByAgeMoreThan(int age, string quality)
        {
            dataGridView1.Rows.Clear();
            if (BookManager.Main != null)
            {
                BookManager.Main.updateBooksQualityByAgeMoreThan(age, quality);
            }
            displayAllBooks();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main != null)
            {
                BookManager.Main.Save();
            }

            FormNew formNew = new FormNew();
            if (formNew.ShowDialog() == DialogResult.OK)
            {
                Authorization.Main.Reset();
                BookManager.Main = BookManager.Create(formNew.Password, formNew.FilePath);
                generateBooks(10, 20);
                BookManager.Main.Save();
                UpdateForm();
            }
        }

        private void allBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main == null)
            {
                return;
            }
            displayAllBooks();
        }

        private void UpdateForm()
        {
            if (BookManager.Main == null)
            {
                searchToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
            } else
            {
                searchToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
            }
            displayAllBooks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (!Authorization.Main.Request())
                {
                    return;
                }
                Book book = BookManager.Main.GetBook(
                    dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                if (book != null)
                {
                    if (book.TakenSince == null)
                    {
                        book.TakenSince = DateTime.Now;
                    } else
                    {
                        book.TakenSince = null;
                    }
                    displayBookAt(e.RowIndex, book);
                    BookManager.Main.Save();
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                Book book = BookManager.Main.GetBook(
                    dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                if (book != null)
                {
                    var propertyInfo = typeof(Book)
                            .GetProperty(senderGrid.Columns[e.ColumnIndex].Name);
                    object cellValue =
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    try
                    {
                        if (cellValue == null)
                        {
                            throw new Exception("Значение не может быть null");
                        }
                        object validatedCellValue = null;
                        string cellText = cellValue.ToString();
                        switch (senderGrid.Columns[e.ColumnIndex].Name)
                        {
                            case "Title":
                                {
                                    validatedCellValue = InputValidator.parseTitle(cellText);
                                }
                                break;
                            case "Author":
                                {
                                    validatedCellValue = InputValidator.parseAuthor(cellText);
                                }
                                break;
                            case "Publisher":
                                {
                                    validatedCellValue = InputValidator.parsePublisher(cellText);
                                }
                                break;
                            case "Year":
                                {
                                    validatedCellValue = InputValidator.parseYear(cellText);
                                }
                                break;
                            case "Quality":
                                {
                                    validatedCellValue = InputValidator.parseQuality(cellText);
                                }
                                break;
                            case "Price":
                                {
                                    validatedCellValue = InputValidator.parsePrice(cellText);
                                }
                                break;
                        }

                        if (validatedCellValue != null && validatedCellValue.ToString() != propertyInfo.GetValue(book).ToString())
                        {
                            if (Authorization.Main.Request())
                            {
                                propertyInfo.SetValue(book, cellText);
                                BookManager.Main.Save();
                            }

                            this.BeginInvoke(new MethodInvoker(() =>
                            {
                                displayBookAt(e.RowIndex, book);
                            }));
                        }
                    } catch (ArgumentException exception)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = exception.Message;
                    } catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.BeginInvoke(new MethodInvoker(() =>
                        {
                            displayBookAt(e.RowIndex, book);
                        }));
                    }
                }
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!Authorization.Main.Request())
            {
                e.Cancel = true;
                return;
            }
            var senderGrid = (DataGridView)sender;

            if (e.Row.Index >= 0)
            {
                BookManager.Main.RemoveBook(
                    dataGridView1.Rows[e.Row.Index].Cells["ID"].Value.ToString());
                BookManager.Main.Save();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(BookManager.DefaultFilePath);
            openFileDialog1.FileName = Path.GetFileName(BookManager.DefaultFilePath);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BookManager bm = BookManager.Load(openFileDialog1.FileName);
                if (bm == null)
                {
                    MessageBox.Show($"Ошибка открытия файл {openFileDialog1.FileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    if (BookManager.Main != null)
                    {
                        BookManager.Main.Save();
                        BookManager.Main = null;
                        Authorization.Main.Reset();
                    }
                    BookManager.Main = bm;
                    UpdateForm();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main != null)
            {
                BookManager.Main.Save();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main != null)
            {
                BookManager.Main.Save();
            }
            Close();
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main == null)
            {
                return;
            }
            FormFilterByTitle form = new FormFilterByTitle();
            if (form.ShowDialog() == DialogResult.OK)
            {
                displayBooksByName(form.Title);
            }
        }

        private void byAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main == null)
            {
                return;
            }
            FormFilterByAuthor form = new FormFilterByAuthor();
            if (form.ShowDialog() == DialogResult.OK)
            {
                displayBooksByAuthor(form.Author);
            }
        }

        private void byPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main == null)
            {
                return;
            }
            FormFilterByPublisher form = new FormFilterByPublisher();
            if (form.ShowDialog() == DialogResult.OK)
            {
                displayBooksByPublisher(form.Publisher);
            }
        }

        private void byYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main == null)
            {
                return;
            }
            FormFilterByYear form = new FormFilterByYear();
            if (form.ShowDialog() == DialogResult.OK)
            {
                displayBooksByYears(form.YearMinimum, form.YearMaximum);
            }
        }

        private void byQualityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main == null)
            {
                return;
            }
            FormFilterByQuality form = new FormFilterByQuality();
            HashSet<string> qualityList = new HashSet<string>();
            BookManager.Main.GetBooks().ForEach((book) =>
            {
                qualityList.Add(book.Quality);
            });
            form.QualityList.AddRange(qualityList.ToArray());
            if (form.ShowDialog() == DialogResult.OK)
            {
                displayBooksByQuality(form.Quality);
            }
        }

        private void byPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main == null)
            {
                return;
            }
            FormFilterByPrice form = new FormFilterByPrice();
            if (form.ShowDialog() == DialogResult.OK)
            {
                displayBooksByPrice(form.PriceMinimum, form.PriceMaximum);
            }
        }

        private void availableBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main == null)
            {
                return;
            }
            displayAvailableBooks();
        }

        private void takenAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main == null)
            {
                return;
            }
            displayTakenBooks();
        }

        private void takenMoreThanThreeMonthsAgoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main == null)
            {
                return;
            }
            displayTakenMoreThanThreeMonthsAgoBooks();
        }

        private void updateBooksQualityByYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateBooksQualityByAge form = new FormUpdateBooksQualityByAge();
            HashSet<string> qualityList = new HashSet<string>();
            BookManager.Main.GetBooks().ForEach((book) =>
            {
                qualityList.Add(book.Quality);
            });
            form.QualityList.AddRange(qualityList.ToArray());
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (Authorization.Main.Request())
                {
                    updateBooksQualityByAgeMoreThan(form.Age, form.Quality);
                }
            }
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddBook form = new FormAddBook();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (Authorization.Main.Request())
                {
                    addBook(form.Title, 
                        form.Author, 
                        form.Publisher, 
                        form.Year, 
                        form.Quality, 
                        form.Price);
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void generateBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookManager.Main != null)
            {
                BookManager.Main.GenerateBooks(10, 20);
                BookManager.Main.Save();
            }

            UpdateForm();
        }
        
        private void RefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reference refer = new Reference();
            refer.Show();
        }
    }
}
