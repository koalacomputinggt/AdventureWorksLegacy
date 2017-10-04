using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorksModel
{


    public class UserPreference
    {
        private int userPreferenceId;
        private int userId;
        private bool likesBlack;
        private bool likesBlue;
        private bool likesGrey;
        private bool likesMulti;
        private bool likesRed;
        private bool likesSilver;
        private bool likesWhite;
        private bool likesYellow;
        private bool preferesMountainBike;
        private bool preferesTouringBike;
        private bool preferesRoadBike;
        private double higherPrice;
        private DateTime createdDate;
        private DateTime modifiedDate;

        public int UserPreferenceId
        {
            get { return userPreferenceId; }
            set { userPreferenceId = value; }
        }
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public bool LikesBlack
        {
            get { return likesBlack; }
            set { likesBlack = value; }
        }
        public bool LikesBlue
        {
            get { return likesBlue; }
            set { likesBlue = value; }
        }
        public bool LikesGrey
        {
            get { return likesGrey; }
            set { likesGrey = value; }
        }
        public bool LikesMulti
        {
            get { return likesMulti; }
            set { likesMulti = value; }
        }
        public bool LikesRed
        {
            get { return likesRed; }
            set { likesRed = value; }
        }
        public bool LikesSilver
        {
            get { return likesSilver; }
            set { likesSilver = value; }
        }
        public bool LikesWhite
        {
            get { return likesWhite; }
            set { likesWhite = value; }
        }
        public bool LikesYellow
        {
            get { return likesYellow; }
            set { likesYellow = value; }
        }
        public bool PreferesMountainBike
        {
            get { return preferesMountainBike; }
            set { preferesMountainBike = value; }
        }
        public bool PreferesTouringBike
        {
            get { return preferesTouringBike; }
            set { preferesTouringBike = value; }
        }
        public bool PreferesRoadBike
        {
            get { return preferesRoadBike; }
            set { preferesRoadBike = value; }
        }
        public double HigherPrice
        {
            get { return higherPrice; }
            set { higherPrice = value; }
        }
        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
        public DateTime ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }
    }
}
