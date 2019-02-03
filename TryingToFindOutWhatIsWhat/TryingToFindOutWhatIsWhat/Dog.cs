using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingToFindOutWhatIsWhat
{
    public class Trainer
    {
        void Operate()
        {
            var dog = new Poodle();
            dog.HasSpoken += dog_HasSpoken;
        }

        private void dog_HasSpoken(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    public  partial class Dog
    {
       
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public event EventHandler HasSpoken; 
        public void Speak(string what = "bark")
        {
            //TODO
            if (HasSpoken!=null)
                HasSpoken(this, EventArgs.Empty);
        }
        public void Speak(int times,bool sit= true,string what = "bark")
        {
            //TODO
        }

    }
    class Poodle : Dog
    {
        void x()
        {
            this.Speak(2, sit:false);
        }
    }
}
