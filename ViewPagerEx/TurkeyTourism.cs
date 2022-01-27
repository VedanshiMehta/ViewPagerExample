using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewPagerEx
{

    public class TurkeyPhoto
    {
        public TurkeyPhoto(int id, string caption)
        {
            PhotoId = id;
            Caption = caption;
        }

        public int PhotoId { get; }
        public string Caption { get; }
    }

    class TurkeyTourism
    {
        static TurkeyPhoto[] toursim = { 
         
           new TurkeyPhoto(Resource.Drawable.TurkeyAnkara,"Ankara"),
           new TurkeyPhoto(Resource.Drawable.TurkeyAntalya,"Antalya"),
           new TurkeyPhoto(Resource.Drawable.TurkeyCappadocia,"Cuppadocia"),
           new TurkeyPhoto(Resource.Drawable.TurkeyEphesus,"Ephesus"),
           new TurkeyPhoto(Resource.Drawable.TurkeyIstanbul,"Istanbul"),
           new TurkeyPhoto(Resource.Drawable.TurkeyIzmir,"Izmir")



        };

        public TurkeyPhoto[] myPhoto;

        public TurkeyTourism()
        {
            myPhoto = toursim;
        }

        public int NumbPhotos
        {
            get { return myPhoto.Length; }
        }

        public TurkeyPhoto this[int i]
        {
            get { return myPhoto[i]; }
        }
    }
      
}