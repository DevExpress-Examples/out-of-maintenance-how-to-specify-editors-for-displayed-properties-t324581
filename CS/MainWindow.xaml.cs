using System.IO;
using System.ComponentModel.DataAnnotations;
using DevExpress.Xpf.Core;
using DevExpress.Mvvm.DataAnnotations;

namespace DXSample {
    public partial class MainWindow : DXWindow {
        public MainWindow() {
            var contact = new Contact {
                FirstName = "Carolyn",
                LastName = "Baker",
                Email = "carolyn.baker@example.com",
                Phone = "(555)349-3010",
                Address = "1198 Theresa Cir",
                City = "Whitinsville",
                State = "MA",
                Zip = "01582",
            };
            contact.Photo = GetPhoto(contact);
            DataContext = contact;
            InitializeComponent();
        }
        byte[] GetPhoto(Contact contact) {
            return GetPhoto(contact.FirstName + contact.LastName + ".jpg");
        }
        byte[] GetPhoto(string name) {
            return File.ReadAllBytes(@"Images\" + name);
        }
    }
    public class Contact {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CreditCardNumber { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        [PropertyGridEditor(TemplateKey = "ImageTemplate")]
        public byte[] Photo { get; set; }
    }
}