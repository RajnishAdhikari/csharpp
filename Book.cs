/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class Book
    {
        
        //CREATING A COMPLEX DATA TYPE
        public string title;
        public string author;
        public string pages;


        //this is for constructor
        
        public Book(string name)
        {
            Console.WriteLine(name);
        }
        
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;

        }
    }

}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    public class Book //in the tutorial there is student but let's consider Book because it's saved 
    {
        public string name;
        public string major;
        public double gpa;
        
        
            public Book(string aName, string aMajor, double aGpa)
            {
                name = aName;
                major = aMajor;
                gpa = aGpa;

            }
            public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
       
    }
   
}



//FOR GETTERS AND SETTERS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    public class Book
    {
        public string title;
        public string director;
        private string rating;

        //in tutorial there is Movie in place of Book
        public Book(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }
        public string Rating
        {
            get { return rating; }
            set 
            { 
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}


//STATIC CLASS ATTRIBUTE
//in place of Book there is Song in the tutorial 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    public class Book
    {
        public string title;
        public string artist;
        public int duration;

        public Book(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            
        }
    }
}

*/
