using System;

namespace Infraestructura
{
    internal class Document
    {
        private object lETTER;
        private int v1;
        private int v2;
        private int v3;
        private int v4;

        public Document(object lETTER, int v1, int v2, int v3, int v4)
        {
            this.lETTER = lETTER;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        internal void AddTitle(string v)
        {
            throw new NotImplementedException();
        }

        internal void AddCreator(string v)
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void AddAuthor(string v)
        {
            throw new NotImplementedException();
        }

        internal void Add(Paragraph paragraph)
        {
            throw new NotImplementedException();
        }
    }
}