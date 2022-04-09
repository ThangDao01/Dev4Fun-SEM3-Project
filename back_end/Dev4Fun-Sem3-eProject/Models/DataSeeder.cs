using Microsoft.EntityFrameworkCore;
using Dev4Fun_Sem3_eProject.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Dev4Fun_Sem3_eProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dev4Fun_Sem3_eProject.Models
{
    public class DataSeeder
    {
        private readonly Dev4Fun_Sem3_eProjectContext _context;

        public DataSeeder(Dev4Fun_Sem3_eProjectContext _context)
        {
            this._context = _context;
        }

        public void Seed()
        {
            if (!_context.Vacancies.Any())
            {
                var vacancies = new List<Vacancies>()
                {
                    new Vacancies
                    {
                        Id=0,
                        OwnedID ="",
                        Title = ".NET Core Developer (ASP.NET/JavaScript)",
                        Description= "Support our customers in writing qualitatively outstanding software according to their needs and requirements Support your team by reviewing code, analyzing and researching new technologies and patterns.  Be responsible for providing quality in code and architecture to our customers Encourage yourself and your team to improve your skills and fill knowledge gaps where occurring. Exchange your knowledge and ideas with other team members, customers, and other technology teams. Be a part of our agile teams, you will take part in the agile rituals and artifacts",
                        NumberOfJobs=100,
                        Status = 0,
                        ApplicantId = "",
                        DepartmentId = "Dev",
                        Thumbnail = "https://netcore.vn/uploads/media/ac1e2ba8-e346-441e-b7c7-b567df17d606.png",
                        Salary = 1300,
                        Address = "Số 8 Tôn Thất Thuyết, Mỹ Đình, TP.HN",
                        Views = 1234,
                        Experience = 2,
                        CareerLevel = "Graduate",
                        Qualification = "Graduate",
                        DateOfExpiration = DateTime.Now,
                        DateOfCreation = DateTime.Now,
                        DateOfUpdate = DateTime.Now,
                    },new Vacancies
                    {
                        Id=0,
                        OwnedID ="",
                        Title = "SENIOR BUSINESS ANALYST | BUSINESS INTELLIGENCE ANALYST",
                        Description= "Support our customers in writing qualitatively outstanding software according to their needs and requirements Support your team by reviewing code, analyzing and researching new technologies and patterns.  Be responsible for providing quality in code and architecture to our customers Encourage yourself and your team to improve your skills and fill knowledge gaps where occurring. Exchange your knowledge and ideas with other team members, customers, and other technology teams. Be a part of our agile teams, you will take part in the agile rituals and artifacts",
                        NumberOfJobs=100,
                        Status = 0,
                        ApplicantId = "",
                        DepartmentId = "Dev",
                        Thumbnail = "https://images.viblo.asia/59f9277c-323f-4c6a-b151-ca52f8778db5.jpg",
                        Salary = 1500,
                        Address = "Số 8 Tôn Thất Thuyết, Mỹ Đình, TP.HN",
                        Views = 1234,
                        Experience = 2,
                        CareerLevel = "Graduate",
                        Qualification = "Graduate",
                        DateOfExpiration = DateTime.Now,
                        DateOfCreation = DateTime.Now,
                        DateOfUpdate = DateTime.Now,
                    },new Vacancies
                    {
                        Id=0,
                        OwnedID ="",
                        Title = "Tuyển dụng Web/API Developer (JETPAY - Trung gian thanh toán)",
                        Description= "Support our customers in writing qualitatively outstanding software according to their needs and requirements Support your team by reviewing code, analyzing and researching new technologies and patterns.  Be responsible for providing quality in code and architecture to our customers Encourage yourself and your team to improve your skills and fill knowledge gaps where occurring. Exchange your knowledge and ideas with other team members, customers, and other technology teams. Be a part of our agile teams, you will take part in the agile rituals and artifacts",
                        NumberOfJobs=100,
                        Status = 0,
                        ApplicantId = "",
                        DepartmentId = "Dev",
                        Thumbnail = "https://static.javatpoint.com/tutorial/webapi/images/web-api-tutorial.png",
                        Salary = 1300,
                        Address = "Số 8 Tôn Thất Thuyết, Mỹ Đình, TP.HN",
                        Views = 1234,
                        Experience = 2,
                        CareerLevel = "Graduate",
                        Qualification = "Graduate",
                        DateOfExpiration = DateTime.Now,
                        DateOfCreation = DateTime.Now,
                        DateOfUpdate = DateTime.Now,
                    },new Vacancies
                    {
                        Id=0,
                        OwnedID ="",
                        Title = "Full-Stack Web Developer with WordPress Experience",
                        Description= "Support our customers in writing qualitatively outstanding software according to their needs and requirements Support your team by reviewing code, analyzing and researching new technologies and patterns.  Be responsible for providing quality in code and architecture to our customers Encourage yourself and your team to improve your skills and fill knowledge gaps where occurring. Exchange your knowledge and ideas with other team members, customers, and other technology teams. Be a part of our agile teams, you will take part in the agile rituals and artifacts",
                        NumberOfJobs=100,
                        Status = 0,
                        ApplicantId = "",
                        DepartmentId = "Dev",
                        Thumbnail = "https://datxanhmienbac.com.vn/public/uploads/source/%E1%BA%A2NH%20TUY%E1%BB%82N%20D%E1%BB%A4NG/30ba31_3965fc9ba4ef4c6e890735526f0d59fa_mv2.jpg",
                        Salary = 1300,
                        Address = "Số 8 Tôn Thất Thuyết, Mỹ Đình, TP.HN",
                        Views = 1234,
                        Experience = 2,
                        CareerLevel = "Graduate",
                        Qualification = "Graduate",
                        DateOfExpiration = DateTime.Now,
                        DateOfCreation = DateTime.Now,
                        DateOfUpdate = DateTime.Now,
                    },
                };
                _context.Vacancies.AddRange(vacancies);
                _context.SaveChanges();
            }
            if (!_context.Accounts.Any())
            {
                var accounts = new List<Accounts>()
                {
                    new Accounts
                    {
                        Id=0,
                        Name="Admin",
                        Email="admin@gmail.com",
                        PhoneNumber="12345678",
                        Password="12345",
                        Thumbnail="https://res.cloudinary.com/thangdao04/image/upload/v1649451832/zuzd0yz1ez0pznqjzsmy.png",
                        Role=0,
                        Description="",
                        DepartmentId="Admin",
                        DateOfCreation=DateTime.Now,
                        DateOfUpdate=DateTime.Now,
                    },
                    new Accounts
                    {
                        Id=1,
                        Name="Đào Thắng",
                        Email="thangddth2009001@fpt.edu.vn",
                        PhoneNumber="12345678",
                        Password="12345",
                        Thumbnail="https://res.cloudinary.com/thangdao04/image/upload/v1648307730/avatar_auto_x2_hbajbf.jpg",
                        Role=1,
                        Description="",
                        DepartmentId="Manager",
                        DateOfCreation=DateTime.Now,
                        DateOfUpdate=DateTime.Now,
                    },
                    new Accounts
                    {
                        Id=2,
                        Name="Minh Quân",
                        Email="quanpmth2009008@fpt.edu.vn",
                        PhoneNumber="12345678",
                        Password="12345",
                        Thumbnail="https://res.cloudinary.com/thangdao04/image/upload/v1649265407/276238021_3042780006052445_3229036904523019164_n.jpg_cjtb5e.jpg",
                        Role=2,
                        Description="",
                        DepartmentId="Mentor",
                        DateOfCreation=DateTime.Now,
                        DateOfUpdate=DateTime.Now,
                    },
                    new Accounts
                    {
                        Id=3,
                        Name="Tiến Nhật",
                        Email="nhatntth2008069@fpt.edu.vn",
                        PhoneNumber="12345678",
                        Password="12345",
                        Thumbnail="https://res.cloudinary.com/thangdao04/image/upload/v1649265472/199334360_635713054492956_7981401750762649022_n.jpg_cxndxz.jpg",
                        Role=3,
                        Description="",
                        DepartmentId="Hr",
                        DateOfCreation=DateTime.Now,
                        DateOfUpdate=DateTime.Now,
                    },
                    new Accounts
                    {
                        Id=4,
                        Name="Mạnh Nam",
                        Email="admin@gmail.com",
                        PhoneNumber="12345678",
                        Password="12345",
                        Thumbnail="https://res.cloudinary.com/thangdao04/image/upload/v1649451832/zuzd0yz1ez0pznqjzsmy.png",
                        Role=4,
                        Description="",
                        DepartmentId="Member",
                        DateOfCreation=DateTime.Now,
                        DateOfUpdate=DateTime.Now,
                    },                    
                };
                _context.Accounts.AddRange(accounts);
                _context.SaveChanges();
            }
        }


    }
}
