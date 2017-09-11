using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorksModel
{
    public class Product
    {
        private int productId;
        private string name;
        private string model;
        private Decimal listPrice;
        private Decimal weight;
        private string unitMeasure;
        private int productSubcategoryId;
        private byte[] thumbnailPhoto;
        private string thumbnailPhotoFileName;
        private string thumbnailPhotoUrl;
        private byte[] largePhoto;
        private string largePhotoFileName;
        private string largePhotoUrl;

        public int ProductId {
            get { return productId; }
            set { productId = value; } 
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Decimal ListPrice
        {
            get { return listPrice; }
            set { listPrice = value; }
        }
        public Decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string UnitMeasure
        {
            get { return unitMeasure; }
            set { unitMeasure = value; }
        }
        public int ProductSubcategoryId {
            get { return productSubcategoryId; }
            set { productSubcategoryId = value; }
        }
        public byte[] ThumbnailPhoto
        {
            get { return thumbnailPhoto; }
            set { thumbnailPhoto = value; }
        }
        public string ThumbnailPhotoFileName
        {
            get { return thumbnailPhotoFileName; }
            set { thumbnailPhotoFileName = value; }
        }
        public string ThumbnailPhotoUrl
        {
            get { return thumbnailPhotoUrl; }
            set { thumbnailPhotoUrl = value; }
        }
        public byte[] LargePhoto
        {
            get { return largePhoto; }
            set { largePhoto = value; }
        }
        public string LargePhotoFileName
        {
            get { return largePhotoFileName; }
            set { largePhotoFileName = value; }
        }
        public string LargePhotoUrl
        {
            get { return largePhotoUrl; }
            set { largePhotoUrl = value; }
        }
    }
}
