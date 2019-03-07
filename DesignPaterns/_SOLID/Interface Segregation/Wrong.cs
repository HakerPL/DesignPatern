using System;
using System.Collections.Generic;

namespace DesignPaterns._SOLID.Interface_Segregation
{
    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }

    public class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            // we implement that function
        }

        public void Print(Document d)
        {
            // we implement that function
        }

        public void Scan(Document d)
        {
            // we implement that function
        }
    }

    public class OldFashionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            // here we have problem , what to do (we dont have that function)
        }

        public void Print(Document d)
        {
            // we implement that function
        }

        public void Scan(Document d)
        {
            // here we have problem , what to do (we dont have that function)
        }
    }

    public class Document
    {
        
    }
}
