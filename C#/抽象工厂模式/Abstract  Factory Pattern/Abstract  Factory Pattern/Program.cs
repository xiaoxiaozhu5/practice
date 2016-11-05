using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract__Factory_Pattern
{
    class Program
    {
        static void Main(string[] args) {
            SkinFactory factory;
            Button bt;
            TextField tf;
            ComboBox cb;
            factory = new SummerSkinFactory();
            bt = factory.creatButton();
            tf = factory.creatTextField();
            cb = factory.creatComboBox();
            bt.display();
            tf.display();
            cb.display();
        }
    }

    public abstract class Button
    {
        public abstract void display();
    }

    class SpringButton : Button
    {
        public override void display() {
            Console.WriteLine("show green button");
        }
    }

    class SummerButton : Button
    {
        public override void display() {
            Console.WriteLine("show blue button");
        }
    }

    public abstract class TextField
    {
        public abstract void display();
    }

    class SpringTextField : TextField
    {
        public override void display() {
            Console.WriteLine("show green text");
        }
    }

    class SummerTextField : TextField
    {
        public override void display() {
            Console.WriteLine("show blue text");
        }
    }

    public abstract class ComboBox
    {
        public abstract void display();
    }

    class SpringComboBox : ComboBox
    {
        public override void display() {
            Console.WriteLine("show green combox");
        }
    }

    class SummerComboBox : ComboBox
    {
        public override void display() {
            Console.WriteLine("show blue combox");
        }
    }

    public abstract class SkinFactory
    {
        public abstract Button creatButton();
        public abstract TextField creatTextField();
        public abstract ComboBox creatComboBox();
    }

    class SpringSkinFactory : SkinFactory
    {
        public override Button creatButton() {
            return new SpringButton();
        }

        public override ComboBox creatComboBox() {
            return new SpringComboBox();
        }

        public override TextField creatTextField() {
            return new SpringTextField();
        }
    }

    class SummerSkinFactory : SkinFactory
    {
        public override Button creatButton() {
            return new SummerButton();
        }

        public override TextField creatTextField() {
            return new SummerTextField();
        }

        public override ComboBox creatComboBox() {
            return new SummerComboBox();
        }
    }
}
