using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PWS_3.Models
{
    public class DB_Context : DbContext
    {
        public DB_Context() : base("ConnectionString")
        { }

        public DbSet<Student> Students { get; set; }

        public List<Student> GetList(int limit, string sort, int offset, int minId, int maxId, string like, string globalLike)
        {
            var students = (IQueryable<Student>)Students;
            students = students.Where(s => s.Id >= minId).Where(s => s.Id <= maxId);

            if (globalLike != null)
                students = students.Where(s => (s.Id + s.Name + s.Phone.ToString()).Contains(globalLike));
            if (like != null)
                students = students.Where(s => s.Name.Contains(like));

            students = sort == "asc" ? students.OrderBy(s => s.Name) : students.OrderByDescending(s => s.Name);
            students = students.Take(limit + offset).Skip(offset);

            return students.ToList();
        }

        public Student GetOne(int id)
        {
            var students = Students.ToList();
            var index = students.IndexOf(students.Find(x => x.Id == id));

            return index != -1
                ? students[index]
                : null;
        }

        public Student Post(string name, string phone)
        {
            var students = Students;
            var id = students.Select(stud => stud.Id).AsEnumerable().Prepend(0).Max();
            var student = new Student { Id = id + 1, Name = name, Phone = phone };

            Students.Add(student);
            SaveChanges();

            return student;
        }

        public Student Put(int id, string name, string phone)
        {
            var students = Students.ToList();
            var index = students.IndexOf(students.Find(x => x.Id == id));

            if (name != null)
                students[index].Name = name;
            if (phone != null)
                students[index].Phone = phone;

            SaveChanges();

            return students[index];
        }

        public Student Delete(int id)
        {
            var students = Students.ToList();
            var removed = students.Find(x => x.Id == id);

            Students.Remove(removed);
            SaveChanges();

            return removed;
        }
    }
}