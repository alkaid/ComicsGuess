using System;
namespace coodroid.Model.model
{
	/// <summary>
	/// subject:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class subject
	{
		public subject()
		{}
		#region Model
		private int _id;
		private string _title;
		private int? _subjecttype;
		private int? _comicstype;
		private int _stage;
		private int _level=0;
		private string _remark;
		private string _resimg;
		private string _restext;
		private string _resaudio;
		private DateTime? _creatdate;
		private string _tip;
		private string _selectors;
		private string _answer;
		private int _sorter=0;
		private bool _resolved= false;
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
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? subjectType
		{
			set{ _subjecttype=value;}
			get{return _subjecttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? comicsType
		{
			set{ _comicstype=value;}
			get{return _comicstype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int stage
		{
			set{ _stage=value;}
			get{return _stage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int level
		{
			set{ _level=value;}
			get{return _level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string resImg
		{
			set{ _resimg=value;}
			get{return _resimg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string resText
		{
			set{ _restext=value;}
			get{return _restext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string resAudio
		{
			set{ _resaudio=value;}
			get{return _resaudio;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? creatdate
		{
			set{ _creatdate=value;}
			get{return _creatdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tip
		{
			set{ _tip=value;}
			get{return _tip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string selectors
		{
			set{ _selectors=value;}
			get{return _selectors;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string answer
		{
			set{ _answer=value;}
			get{return _answer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sorter
		{
			set{ _sorter=value;}
			get{return _sorter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool resolved
		{
			set{ _resolved=value;}
			get{return _resolved;}
		}
		#endregion Model

	}
}

