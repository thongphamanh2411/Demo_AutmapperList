using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_AutmapperList
{
	class Program
	{
		static void Main(string[] args)
		{

			var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Source, Destination>());
			var mapper = new Mapper(configuration);
            //Ứng dụng cho việc multiple mapping sẽ nhận cấu trúc của nhiều class
            //List<Object1, Object2>   -> Mapping giữa Object[], List()
			var sources = new[]
				{
					new Source { Value = 5 },
					new Source { Value = 6 },
					new Source { Value = 7 }
				};

			
			Destination[] arrayDest = mapper.Map<Source[], Destination[]>(sources);
         
		}
	}

	public class Source
	{
		public int Value { get; set; }
	}

	public class Destination
	{
		public int Value { get; set; }
	}
}
