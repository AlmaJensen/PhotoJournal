using Journal.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.Interfaces
{
	public interface IMemberService
	{
		void CreateMember(MemberModel memberModel);
		MemberModel ReadMember(string email);
		void UpdateMember(MemberModel memberModel);
		void DeleteMember(MemberModel memberModel);
	}
}
