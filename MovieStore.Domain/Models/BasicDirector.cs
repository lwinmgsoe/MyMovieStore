
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Domain.Models
{
    public class BasicDirector
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BasicDirector()
        {

        }
        public BasicDirector(Director director)
        {
            Id = director.Id;
            Name = director.Name;
        }
    }
}
