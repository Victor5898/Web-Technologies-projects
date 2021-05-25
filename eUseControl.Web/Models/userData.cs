using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eUseControl.Domain.Entities.Product;

namespace eUseControl.Web.Models
{
    public class userData
    {
        public string Username { get; set; }
        public List<ProductDetail> CourseObj { get; set; }
        public List<Element> ElemObj { get; set; }
        public List<Facilities> FacilitiesObj { get; set; }
        public List<Slide> SlideObj { get; set; }
        public List<Service> ServiceObj { get; set; }
        public List<Teacher> TeacherObj { get; set; }
        public List<Comment> CommentObj { get; set; }
        public List<Blog> BlogObj { get; set; }
        public List<string> CategoryObj { get; set; }
        public List<News> NewsObj { get; set; }
        public List<Achieve> AchieveObj { get; set; }
        public List<string> TagObj { get; set; }
        public string SingleCourse { get; set; }
        public CourseDetails CDetails { get; set; }
    }

    public class Element
    {

        public string LastCourse_images { get; set; }
        public string LastCourse_name { get; set; }
        public string LastCourse_price { get; set; }
        public string LastCourse_description { get; set; }
        public string LastCourse_days { get; set; }
    }


    public class Facilities
    {
        public string Facilities_name { get; set; }
        public string Facilities_descript { get; set; }
    }

    public class Slide
    {
        public string Slide_title { get; set; }
        public string Slide_name { get; set; }
        public string Slide_descript { get; set; }
        public string Slide_img { get; set; }
    }

    public class Service
    {
        public string Service_title { get; set; }
        public string Service_descript { get; set; }
    }

    public class Teacher
    {
        public string Teacher_Name { get; set; }
        public string Teacher_Job { get; set; }
        public string Teacher_Descript { get; set; }
        public string Teacher_img { get; set; }
    }

    public class Comment
    {
        public string Comment_Author { get; set; }
        public string Comment_Content { get; set; }
        public string Comment_Img { get; set; }
    }

    public class Blog
    {
        public string Blog_Title { get; set; }
        public string Blog_Author { get; set; }
        public string Blog_Date { get; set; }
        public string Blog_Comm { get; set; }
        public string Blog_Descript { get; set; }
        public string Blog_Img { get; set; }
    }

    public class News
    {
        public string News_Img { get; set; }
        public string News_Title { get; set; }
        public string News_Price { get; set; }
    }

    public class Achieve
    {
        public string Achieve_Month { get; set; }
        public string Achieve_Number { get; set; }
    }
}

