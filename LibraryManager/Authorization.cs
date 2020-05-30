using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    class Authorization
    {
        private DateTime? lastSuccessfulAuthorization = null;
        public static Authorization Main = new Authorization();

        private Authorization() { }
        
        public void Reset()
        {
            lastSuccessfulAuthorization = null;
        } 

        public bool Request()
        {
            if (BookManager.Main == null)
            {
                return false;
            }
            if (lastSuccessfulAuthorization != null &&
                DateTime.Now.Subtract(TimeSpan.FromMinutes(5)) <= lastSuccessfulAuthorization)
            {
                return true;
            }
            FormAuthorizationRequest form = new FormAuthorizationRequest();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.Password == BookManager.Main.Password)
                {
                    lastSuccessfulAuthorization = DateTime.Now;
                    return true;
                } else
                {
                    lastSuccessfulAuthorization = null;
                    MessageBox.Show("Invalid password", "Authorization Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }
    }
}
