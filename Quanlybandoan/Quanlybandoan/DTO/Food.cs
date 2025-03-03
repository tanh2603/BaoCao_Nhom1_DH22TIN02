﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlybandoan.DTO
{
    public class Food
    {
        public Food(int id, string name, int categoryID, float price)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["Mamonan"];
            this.Name = row["Tenmonan"].ToString();
            this.CategoryID = (int)row["Maloai"];
            this.Price = (float)Convert.ToDouble(row["DonGia"].ToString());
        }

        private int iD;

        private string name;

        private int categoryID;

        private float price;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
