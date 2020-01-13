using System;
using System.Collections.Generic;
using System.Text;

namespace MathiasSvendsen.KompetenceTestS1.KompetenceDel
{
    class Film
    {
        // Fields
        private string title;
        private int date;
        private string director;
        private string productionCompany;

        // Constructor
        public Film(string title, int date, string director, string productionCompany)
        {
            Title = title;
            Date = date;
            Director = director;
            ProductionCompany = productionCompany;
        }

        // Properties
        // Title of movie
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        // Date of movie
        public int Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        // Director
        public string Director
        {
            get
            {
                return director;
            }
            set
            {
                director = value;
            }
        }
        // Production company
        public string ProductionCompany
        {
            get
            {
                return productionCompany;
            }
            set
            {
                productionCompany = value;
            }
        }
    }
}
