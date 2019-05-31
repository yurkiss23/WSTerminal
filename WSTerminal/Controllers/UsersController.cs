using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WSTerminal.Entities;
using WSTerminal.Models;

namespace WSTerminal.Controllers
{
    public class UsersController : ApiController
    {
        private static EFContext _context = new EFContext();
        private static List<UserModel> _userView = new List<UserModel>(
            _context.Users.Select(u => new UserModel()
            {
                Id = u.Id,
                Money = u.Money,
                Fname = u.Fname,
                Lname = u.Lname,
                Phone = u.Phone,
                Email = u.Email,
                Password = u.Password
            }).ToList());

        public List<UserModel> Get()
        {
            return _userView;
        }

        public IHttpActionResult Post(AddUserModel model)
        {
            _context.Users.Add(new Entities.User()
            {
                Money = 0,
                Fname = model.Fname,
                Lname = model.Lname,
                Phone = model.Phone,
                Email = model.Email,
                Password = model.Password
            });
            //_context.SaveChanges();
            return Ok();
        }

        //public IHttpActionResult Delete(string id)
        //{
        //    _context.Users.Remove(_context.Users.Where(u => u.Id == Int32.Parse(id)).First());
        //    _context.SaveChanges();
        //    return Ok();
        //}
    }
}
