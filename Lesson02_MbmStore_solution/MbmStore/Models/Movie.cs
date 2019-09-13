﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie
    {
        // fields
        private string title;
        private double price;
        //private string imageUrl;
        private string director;

        // properties
        public string Title
        {
            get { return title; } // read
            //set { name = value; } // write
        }

        public double Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }


        public string ImageUrl
        {
            get; set; // autoimplemented property
            //get { return imageUrl; }
            //set { imageUrl = value; }
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        // constructors
        public Movie(string title, double price)
        {
            this.title = title;
            this.price = price;
        }

        public Movie(string title, double price, string imageUrl, string director)
        {
            this.title = title;
            this.price = price;
            ImageUrl = imageUrl;
            this.director = director;
        }
    }
}