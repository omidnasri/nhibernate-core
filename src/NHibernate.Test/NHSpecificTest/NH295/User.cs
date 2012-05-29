using System;
using Iesi.Collections.Generic;

namespace NHibernate.Test.NHSpecificTest.NH295
{
	[Serializable]
	public class User : Party
	{
		private ISet<UserGroup> _groups = new HashedSet<UserGroup>();

		internal User() : this("")
		{
		}

		internal User(string name)
			: base(name)
		{
		}

		public ISet<UserGroup> Groups
		{
			get { return _groups; }
			set { _groups = value; }
		}
	}
}