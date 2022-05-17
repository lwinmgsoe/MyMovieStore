using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Domain.Models
{
    public class BasicActorCast
    {
        public int Id { get; set; }
        public string CastName { get; set; }
        public string ActorName { get; set; }
    }
}
