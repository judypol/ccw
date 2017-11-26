using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCW.Models
{
    public class LinkCardModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }

        public IDialogCoordinator DialogCoordinator { get; set; }

        public async void Top()
        {
            await DialogCoordinator.ShowMessageAsync(this, "122", "yudy");
        }
    }
}
