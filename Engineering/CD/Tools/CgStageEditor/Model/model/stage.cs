using System;
namespace coodroid.Model.model
{
	/// <summary>
	/// stage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class stage
	{
		public stage()
		{}
		#region Model
		private int _id;
		private string _name;
		private int _catalog;
		private int _stagetype;
		private bool _unlocked= false;
		private int? _nearsubject;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int catalog
		{
			set{ _catalog=value;}
			get{return _catalog;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int stageType
		{
			set{ _stagetype=value;}
			get{return _stagetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool unlocked
		{
			set{ _unlocked=value;}
			get{return _unlocked;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? nearSubject
		{
			set{ _nearsubject=value;}
			get{return _nearsubject;}
		}
		#endregion Model

	}
}

