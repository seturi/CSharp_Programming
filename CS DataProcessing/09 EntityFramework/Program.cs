using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MyDbContext();

            // INSERT
            var c1 = new Customer();
            c1.Name = "Kim";
            c1.Email = "kim@mail.com";
            c1.CreateDate = DateTime.Now;

            db.Customers.Add(c1);   // 추가
            db.SaveChanges();       // 저장

            // UPDATE
            var c2 = db.Customers.SingleOrDefault(p => p.Name == "Lee");

            c2.Email = "lee@test.com";  // 수정
            c2.Age = 20;

            db.SaveChanges();           // 저장

            // DELETE
            var c3 = db.Customers.SingleOrDefault(p => p.Name == "Kim");
            if (c3 == null) return;

            db.Customers.Remove(c3);    // 삭제
                                        // 복수일 경우: db.Customers.RemoveRange(clist);

            db.SaveChanges();           // 저장


            // SELECT
            // 이름이 Suzy인 고객 쿼리
            var c4 = db.Customers.SingleOrDefault(p => p.Name == "Suzy");

            // 이름이 Lee인 첫번째 레코드
            var c5 = db.Customers.FirstOrDefault(p => p.Name == "Lee");

            // 10대 고객 10명만
            var c6 = db.Customers.Where(p => p.Age >= 10 && p.Age < 20).Take(10);

            // 최연소자이면서 키가 가장 큰 고객
            // (ORDER BY Age ASC, Height DESC)
            var c7 = db.Customers.OrderBy(p => p.Age).ThenByDescending(p => p.Height);
        }
    }
}
