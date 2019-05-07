
using System.Data;

namespace LibOfTimetableOfClasses
{
	interface IController
	{
		bool Delete(Model model);
		bool Insert(Model model);
		bool Update(Model model);
	}
}
