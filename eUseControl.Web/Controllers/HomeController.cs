using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.Web.Models;
using eUseControl.Domain.Entities.User;
using eUseControl.Domain.Enums;
using eUseControl.Domain.Entities.User.Global;
using eUseControl.BusinessLogic.DBModel.Seed;
using eUseControl.Domain.Entities.Product;
using eUseControl.Web.Extensions;

namespace eUseControl.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            userData u = new userData();
            u.ElemObj = new List<Element>();
            u.FacilitiesObj = new List<Facilities>();
            u.SlideObj = new List<Slide>();
            u.ServiceObj = new List<Service>();
            u.TeacherObj = new List<Teacher>();
            u.CommentObj = new List<Comment>();
            u.BlogObj = new List<Blog>();
            u.CourseObj = new List<ProductDetail>();


            if(user == null)
            {
                u.Username = "Username";
            }
            else
            {
                u.Username = user.Username;
            }
            

            List<string> CourseDescription = new List<string> { "Vrei sa inveti tehnicile de testare in limbajul Java? Atunci aplica la acest curs!", "Limbajul C# este un limbaj orientat pe obiecte, foarte utilizat la crearea aplicatiilor web", "UML este cea mai populara aplicatie de modelare a aplicatiilor" };
            List<string> CourseName = new List<string> { "Testarea automata in Java", "Bazele C#", "Modelarea aplicatiilor in UML" };
            List<string> CoursePrice = new List<string> { "$165.00", "$165.00", "$165.00" };
            List<string> CourseDaysAfter = new List<string> { "60days", "90days", "50days" };

            for (int i = 0; i < 3; i++)
            {
                Element eo = new Element();
                eo.LastCourse_images = String.Format("Content/img/courses/{0}.jpg", i + 1);
                eo.LastCourse_description = CourseDescription[i];
                eo.LastCourse_name = CourseName[i];
                eo.LastCourse_price = CoursePrice[i];
                eo.LastCourse_days = CourseDaysAfter[i];

                u.ElemObj.Add(eo);
            }

            List<string> FacilitName = new List<string> { "Cursuri profesionale", "Profesori experti", "Invatarea online", "Lectii audio", "Lectii video", "Certificat la absolvirea cursului" };
            List<string> FacilitDescript = new List<string> { "In cadrul cursurilor, abordam o gama larga de subiecte, imbinand armomnios teoria cu practica.", "Toti profesorii lucreaza in domeniu de mult ani, reusind sa puna in aplicare multe proiecte in IT.", "Pe site-ul nostru gasiti cursuri online pentru orice domeniu al IT-ului, care va vor ajuta sa patrundeti in tainele domeniului IT.", "Unele lectii teoretice sunt disponibile sub forma de podcast-uri, care sunt utile pentru a asimila informatia.", "Aici ai posibilitate de a viziona lectii video, sunt prezentate sintaxa limbajului, algoritmi si dievrse implementari in limbaj.", "La sfarsitul fiecarui curs poti primi un certificat profesional, care va permite angajarea in domeniul ales." };

            for (int i = 0; i < 6; i++)
            {
                Facilities fo = new Facilities();
                fo.Facilities_name = FacilitName[i];
                fo.Facilities_descript = FacilitDescript[i];

                u.FacilitiesObj.Add(fo);
            }

            List<string> SlideName = new List<string> { "Bun venit la I++ courses", "Invata de la cei mai buni", "Exclusiv pentru programare" };
            List<string> SlideTitle = new List<string> { "Noi te vom ajuta sa inveti", "Te va indruma o echipa de profesionisti", "Cursuri pentru oricine" };
            List<string> SlideDescript = new List<string> { "Aceste cursuri sunt destinate celor care vor sa isi consolideze cunostintele, sa creasca profesional sau pur si simplu persoanelor care dorec sa invete ceva nou.", "Toti profesorii in cadrul acestor cursuri sunt persoane cu experienta in domeniu, ce te vor ajuta sa patrunzi in tainele programarii si informaticii.", "Aceste cursuri sunt exclusiv de programare, disponibile atat pentru adolescenti, cat si pentru maturi." };

            for (int i = 0; i < 3; i++)
            {
                Slide so = new Slide();
                so.Slide_img = String.Format("Content/img/slider/{0}.jpg", i + 1);
                so.Slide_name = SlideName[i];
                so.Slide_title = SlideTitle[i];
                so.Slide_descript = SlideDescript[i];

                u.SlideObj.Add(so);
            }

            List<string> ServiceTitle = new List<string> { "Invata online", "Profesori experti", "Atmosfera motivanta" };
            List<string> ServiceDescript = new List<string> { "Majoritatea cursurilor I++ sunt disponibile si in format online, ceia ce poate fi o alegere perfecta pentru perioada de carantina.", "E bine sa inveti singur, dar e mult mai bine cand esti indrumat de catre persoane cu experienta, care stiu sa motiveze.", "Salile noastre de clasa creaza conditii excelente pentru invatare, teoria fiind combinata perfect cu exercitii practice." };

            for (int i = 0; i < 3; i++)
            {
                Service sero = new Service();
                sero.Service_title = ServiceTitle[i];
                sero.Service_descript = ServiceDescript[i];

                u.ServiceObj.Add(sero);
            }

            List<string> TeacherName = new List<string> { "Brian Dean", "James Hein", "Rebeca Michel", "John Doe" };
            List<string> TeacherJob = new List<string> { "Dezvoltator Java", "Dezvoltator web", "Developer C#", "Profesor de programare" };
            List<string> TeacherDescript = new List<string> { "Brian, fiind totodata si profesor la universitate, ajuta elevii sai sa devina cei mai buni.", "Avand o experienta profesionala de 15 ani, James Hein este un profesionist dedicat lucrului sau, fiind gata sa isi impartaseasca experienta acumulata cu elevii sai.", "Rebeca este o persoana energica, care stie cum sa faca lectia interesanta si productiva.", "Pedagog cu o experienta vasta, fiind ingenios si perseverent, stie cum sa faca elevii sa indrageasca programarea." };

            for (int i = 0; i < 4; i++)
            {
                Teacher to = new Teacher();
                to.Teacher_img = String.Format("Content/img/teachers/teacher-0{0}.png", i + 1);
                to.Teacher_Name = TeacherName[i];
                to.Teacher_Job = TeacherJob[i];
                to.Teacher_Descript = TeacherDescript[i];

                u.TeacherObj.Add(to);
            }

            List<string> CommentAuthor = new List<string> { "John Doe", "Rebaca Michel", "Stev Smith" };
            List<string> CommentContent = new List<string> { "Mult timp cautam cursuri potrivite in domeniul testarii automate. O colega mi-a sugerat I++. Este o platforma educationala care m-a impresionat prin atitudinea profesorilor si modul de predare.", "Am ramas placut surprins de cursurile I++. Aceste cursuri pun accentul pe particularitile de productie in orice domeniu IT, ceia ce este extrem de important unui developer modern.", "Multumesc cursurilor I++ ca mi-au oferit posibilitatea de a studia ceva noi, fiind acasa." };

            for (int i = 0; i < 3; i++)
            {
                Comment comObj = new Comment();
                comObj.Comment_Author = CommentAuthor[i];
                comObj.Comment_Content = CommentContent[i];
                comObj.Comment_Img = String.Format("Content/img/testimonial-{0}.png", i + 1);

                u.CommentObj.Add(comObj);
            }

            List<string> BlogTitle = new List<string> { "Inceputul acest proiect", "Care este cel mai bun limbaj", "Medii de dezvoltare (IDE)" };
            List<string> BlogDate = new List<string> { "02 June 2016", "02 June 2016", "02 June 2016" };
            List<string> BlogAuthor = new List<string> { "By Admin", "By Admin", "By Admin" };
            List<string> BlogComm = new List<string> { "87", "87", "87" };
            List<string> BlogDescript = new List<string> { "Fiind inca pe bancile universitatii m-a inspirat idea de a crea o platforma educationala, unde se va invata domeniul IT. In cadrul proiectului de licenta, am reusit sa implementez acest proiect...", "Studiind multe dintre limbajele existente in prezent, pot spune ca fiecare are particularitatile sale, fiind utilizate in dieverse domenii. De aceia pot afirma ca cel mai bun limbaj e acel pe care il cunosti...", "Cea mai comoda metoda de a compila si rula aplicatiile este un mediu de dezvoltare (IDE), care contine toate instrumentele si bibliotecile necesare pentru cele mai complexe sarcini..." };

            for (int i = 0; i < 3; i++)
            {
                Blog blogObj = new Blog();
                blogObj.Blog_Title = BlogTitle[i];
                blogObj.Blog_Author = BlogAuthor[i];
                blogObj.Blog_Date = BlogDate[i];
                blogObj.Blog_Comm = BlogComm[i];
                blogObj.Blog_Descript = BlogDescript[i];
                blogObj.Blog_Img = String.Format("Content/img/blog/blog-{0}.jpg", i + 1);

                u.BlogObj.Add(blogObj);
            }

            return View(u);
        }

    }
}