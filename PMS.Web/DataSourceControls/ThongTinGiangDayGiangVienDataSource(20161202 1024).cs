#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.ThongTinGiangDayGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThongTinGiangDayGiangVienDataSourceDesigner))]
	public class ThongTinGiangDayGiangVienDataSource : ProviderDataSource<ThongTinGiangDayGiangVien, ThongTinGiangDayGiangVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThongTinGiangDayGiangVienDataSource class.
		/// </summary>
		public ThongTinGiangDayGiangVienDataSource() : base(new ThongTinGiangDayGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThongTinGiangDayGiangVienDataSourceView used by the ThongTinGiangDayGiangVienDataSource.
		/// </summary>
		protected ThongTinGiangDayGiangVienDataSourceView ThongTinGiangDayGiangVienView
		{
			get { return ( View as ThongTinGiangDayGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThongTinGiangDayGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public ThongTinGiangDayGiangVienSelectMethod SelectMethod
		{
			get
			{
				ThongTinGiangDayGiangVienSelectMethod selectMethod = ThongTinGiangDayGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThongTinGiangDayGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThongTinGiangDayGiangVienDataSourceView class that is to be
		/// used by the ThongTinGiangDayGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the ThongTinGiangDayGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<ThongTinGiangDayGiangVien, ThongTinGiangDayGiangVienKey> GetNewDataSourceView()
		{
			return new ThongTinGiangDayGiangVienDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the ThongTinGiangDayGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThongTinGiangDayGiangVienDataSourceView : ProviderDataSourceView<ThongTinGiangDayGiangVien, ThongTinGiangDayGiangVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThongTinGiangDayGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThongTinGiangDayGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThongTinGiangDayGiangVienDataSourceView(ThongTinGiangDayGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThongTinGiangDayGiangVienDataSource ThongTinGiangDayGiangVienOwner
		{
			get { return Owner as ThongTinGiangDayGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThongTinGiangDayGiangVienSelectMethod SelectMethod
		{
			get { return ThongTinGiangDayGiangVienOwner.SelectMethod; }
			set { ThongTinGiangDayGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThongTinGiangDayGiangVienService ThongTinGiangDayGiangVienProvider
		{
			get { return Provider as ThongTinGiangDayGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThongTinGiangDayGiangVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThongTinGiangDayGiangVien> results = null;
			ThongTinGiangDayGiangVien item;
			count = 0;
			
			System.String _maGiangVien;
			System.String _maLopHocPhan;
			System.String sp2886_NamHoc;
			System.String sp2886_HocKy;
			System.String sp2886_MaGiangVien;
			System.String sp2886_MaLopHocPhan;

			switch ( SelectMethod )
			{
				case ThongTinGiangDayGiangVienSelectMethod.Get:
					ThongTinGiangDayGiangVienKey entityKey  = new ThongTinGiangDayGiangVienKey();
					entityKey.Load(values);
					item = ThongTinGiangDayGiangVienProvider.Get(entityKey);
					results = new TList<ThongTinGiangDayGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThongTinGiangDayGiangVienSelectMethod.GetAll:
                    results = ThongTinGiangDayGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThongTinGiangDayGiangVienSelectMethod.GetPaged:
					results = ThongTinGiangDayGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThongTinGiangDayGiangVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThongTinGiangDayGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThongTinGiangDayGiangVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThongTinGiangDayGiangVienSelectMethod.GetByMaGiangVienMaLopHocPhan:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.String)) : string.Empty;
					_maLopHocPhan = ( values["MaLopHocPhan"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String)) : string.Empty;
					item = ThongTinGiangDayGiangVienProvider.GetByMaGiangVienMaLopHocPhan(_maGiangVien, _maLopHocPhan);
					results = new TList<ThongTinGiangDayGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case ThongTinGiangDayGiangVienSelectMethod.GetByNamHocHocKyMaGiangVienMaLopHocPhan:
					sp2886_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2886_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp2886_MaGiangVien = (System.String) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.String));
					sp2886_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					results = ThongTinGiangDayGiangVienProvider.GetByNamHocHocKyMaGiangVienMaLopHocPhan(sp2886_NamHoc, sp2886_HocKy, sp2886_MaGiangVien, sp2886_MaLopHocPhan, StartIndex, PageSize);
					break;
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == ThongTinGiangDayGiangVienSelectMethod.Get || SelectMethod == ThongTinGiangDayGiangVienSelectMethod.GetByMaGiangVienMaLopHocPhan )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				ThongTinGiangDayGiangVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThongTinGiangDayGiangVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<ThongTinGiangDayGiangVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThongTinGiangDayGiangVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThongTinGiangDayGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThongTinGiangDayGiangVienDataSource class.
	/// </summary>
	public class ThongTinGiangDayGiangVienDataSourceDesigner : ProviderDataSourceDesigner<ThongTinGiangDayGiangVien, ThongTinGiangDayGiangVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThongTinGiangDayGiangVienDataSourceDesigner class.
		/// </summary>
		public ThongTinGiangDayGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThongTinGiangDayGiangVienSelectMethod SelectMethod
		{
			get { return ((ThongTinGiangDayGiangVienDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new ThongTinGiangDayGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThongTinGiangDayGiangVienDataSourceActionList

	/// <summary>
	/// Supports the ThongTinGiangDayGiangVienDataSourceDesigner class.
	/// </summary>
	internal class ThongTinGiangDayGiangVienDataSourceActionList : DesignerActionList
	{
		private ThongTinGiangDayGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThongTinGiangDayGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThongTinGiangDayGiangVienDataSourceActionList(ThongTinGiangDayGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThongTinGiangDayGiangVienSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion ThongTinGiangDayGiangVienDataSourceActionList
	
	#endregion ThongTinGiangDayGiangVienDataSourceDesigner
	
	#region ThongTinGiangDayGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThongTinGiangDayGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum ThongTinGiangDayGiangVienSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaGiangVienMaLopHocPhan method.
		/// </summary>
		GetByMaGiangVienMaLopHocPhan,
		/// <summary>
		/// Represents the GetByNamHocHocKyMaGiangVienMaLopHocPhan method.
		/// </summary>
		GetByNamHocHocKyMaGiangVienMaLopHocPhan
	}
	
	#endregion ThongTinGiangDayGiangVienSelectMethod

	#region ThongTinGiangDayGiangVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThongTinGiangDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThongTinGiangDayGiangVienFilter : SqlFilter<ThongTinGiangDayGiangVienColumn>
	{
	}
	
	#endregion ThongTinGiangDayGiangVienFilter

	#region ThongTinGiangDayGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThongTinGiangDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThongTinGiangDayGiangVienExpressionBuilder : SqlExpressionBuilder<ThongTinGiangDayGiangVienColumn>
	{
	}
	
	#endregion ThongTinGiangDayGiangVienExpressionBuilder	

	#region ThongTinGiangDayGiangVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThongTinGiangDayGiangVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThongTinGiangDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThongTinGiangDayGiangVienProperty : ChildEntityProperty<ThongTinGiangDayGiangVienChildEntityTypes>
	{
	}
	
	#endregion ThongTinGiangDayGiangVienProperty
}

