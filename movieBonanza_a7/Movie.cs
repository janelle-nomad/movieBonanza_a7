/**
 * Janelle Heron
 * COMP123
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieBonanza_a7
{
    //Movie class
    public class Movie
    {
        //private instance variables
        private string _title, _category;
        private double _cost;

     
        public string Title
        {
            get
            {
                return this._title; //read only
            }
        }
        public string Category
        {
            get
            {
                return this._category; //read only
            }
        }
        public double Cost
        {
            get
            {
                return this._cost; //read only
            }
        }

        //***** CONSTRUCTOR *****//
        public Movie(string title, string category, double cost)
        {
            // Assign values to instance variables
            this._title = title;
            this._category = category;
            this._cost = cost;

        }

        private double _AssignCost(string Category)
        {
            switch (Category)
            {
                case "Sci-Fi":
                case "Comedy":
                    return 1.99;

                case "Drama":
                case "Action":
                case "Horror":
                case "Thriller":
                case "Family":
                case "New Releases":
                    return 4.99;

                default: return 0;

            }

        }
    }
}

