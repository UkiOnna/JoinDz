using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinDz
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DocumentModel context = new DocumentModel())
            {
                context.Documents.ToList();
                var result = from doc in context.Documents
                             join sub in context.Signatures on doc.Id equals sub.DocumentId
                             join per in context.People on sub.PersonId equals per.Id
                             where per.Id == doc.PersonId
                             select new { Theme = doc.DocumentTheme, Creator = doc.Creator.Name, CretionDate = doc.CretionDate, Subscribers = doc.Subscribers.Select(s => s.Person.Name)};





            }
        }
    }
}
