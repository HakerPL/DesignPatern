using System;
using System.Collections.Generic;

namespace DesignPaterns._SOLID.Interface_Segregation
{
    /*
     * Interface Segregation
     * Don't put too much into an interface, split into separate interfaces
     * YAGNI - You Ain't Going to Need It
     */

    public interface IPrinter
    {
        void Print(Document d);
    }

    public interface IScanner
    {
        void Scan(Document d);
    }

    public interface IFax
    {
        void Fax(Document d);
    }

    public interface IMultiFunctionDevice : IScanner, IPrinter, IFax
    {
        
    }

    public class PhotoCopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            // we implement that function
        }

        public void Scan(Document d)
        {
            // we implement that function
        }
    }

    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        private readonly IPrinter _printer;
        private readonly IScanner _scanner;
        private readonly IFax _fax;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner, IFax fax)
        {
            _printer = printer;
            _scanner = scanner;
            _fax = fax;
        }

        public void Fax(Document d)
        {
            _fax.Fax(d);
        }

        public void Print(Document d)
        {
            _printer.Print(d);
        }

        public void Scan(Document d)
        {
            _scanner.Scan(d);
        }
    }

}
