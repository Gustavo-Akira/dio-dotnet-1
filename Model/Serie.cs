using System;
using gustavoakira.series.Enums;

namespace gustavoakira.series.Model
{
    public class Serie: BaseEntity
    {
        private Genre Genre {get; set;}

        private string Title{get;set;}

        private string Description{get;set;}

        private int Year{get;set;}

        private bool Excluded{get;set;}
    
        public Serie(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Excluded = false;
        }

        public override string ToString()
        {
            string representation = "";
            representation += "Genre: "+this.Genre+Environment.NewLine; 
            representation += "Title: "+this.Title+Environment.NewLine;
            representation += "Description: "+ this.Description + Environment.NewLine;
            representation += "Start Year: "+this.Year+Environment.NewLine;
            return representation;
        }

        public void Remove(){
            this.Excluded = true;
        }

        public int GetId(){
            return this.Id;
        }

        public string GetTitle(){
            return this.Title;
        }

        public int GetYear(){
            return this.Year;
        }

        public string GetDescription(){
            return this.Description;
        }

        public bool IsExcluded(){
            return this.Excluded;
        }
    }
    
}