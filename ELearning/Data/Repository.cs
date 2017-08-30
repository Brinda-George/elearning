using ELearning.Models;
using ELearning.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELearning.Data
{
    public class Repository
    {
        Context context = new Context();
        public void insert(RegisterModel regi)
        {
            context.reg.Add(regi);
            context.SaveChanges();
        }
        //public void insert1(CheckBox che)
        //{
        //    context.check.Add(che);
        //    context.SaveChanges();
        //}
        //public void update(DetailsModel det,string hard)
        //{
        //    var userDetails = context.detail.Where(us => us.id == det.id).SingleOrDefault();
        //    userDetails.hardware = hard;
        //    context.SaveChanges();
        //}
        public IEnumerable<string> CountryDrop()
        {
            var tempList = context.ConDrop.Select(x => x.country).ToList();
            return tempList;
        }
        public IEnumerable<string> Month()
        {
            var tempList = context.Birth.Select(x => x.month).ToList();
            return tempList;
        }
        public IEnumerable<int> Day()
        {
            var tempList = context.Birth.Select(x => x.day).ToList();
            return tempList;
        }

        public IEnumerable<int> Year()
        {
            var tempList = context.Birth.Select(x => x.year).ToList();
            return tempList;
        }

        public IEnumerable<string> Technology()
        {
            var tempList = context.mat.Select(x => x.technology).ToList();
            return tempList;
        }

        public MaterialModel Search(string technology)
        {

            var tempList = context.mat.Where(us => us.technology == technology).FirstOrDefault();
            return tempList;
        }
        public int login(StartPage_ViewModel start)
        {
            int temp = 1;
            var uname = context.reg.Where(x => x.username == start.username && x.password == start.password).FirstOrDefault();

            if (uname != null)
            {
                temp++;
            }
            return temp;
        }
    }
}