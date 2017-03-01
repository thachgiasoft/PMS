#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.ViewSoTietCoiThiTieuChuanCuaGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner))]
	public class ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource : ReadOnlyDataSource<ViewSoTietCoiThiTieuChuanCuaGiangVien>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource class.
		/// </summary>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource() : base(new ViewSoTietCoiThiTieuChuanCuaGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceView used by the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource.
		/// </summary>
		protected ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceView ViewSoTietCoiThiTieuChuanCuaGiangVienView
		{
			get { return ( View as ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod SelectMethod
		{
			get
			{
				ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod selectMethod = ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceView class that is to be
		/// used by the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewSoTietCoiThiTieuChuanCuaGiangVien, Object> GetNewDataSourceView()
		{
			return new ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceView : ReadOnlyDataSourceView<ViewSoTietCoiThiTieuChuanCuaGiangVien>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceView(ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource ViewSoTietCoiThiTieuChuanCuaGiangVienOwner
		{
			get { return Owner as ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod SelectMethod
		{
			get { return ViewSoTietCoiThiTieuChuanCuaGiangVienOwner.SelectMethod; }
			set { ViewSoTietCoiThiTieuChuanCuaGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewSoTietCoiThiTieuChuanCuaGiangVienService ViewSoTietCoiThiTieuChuanCuaGiangVienProvider
		{
			get { return Provider as ViewSoTietCoiThiTieuChuanCuaGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewSoTietCoiThiTieuChuanCuaGiangVien> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewSoTietCoiThiTieuChuanCuaGiangVien> results = null;
			// ViewSoTietCoiThiTieuChuanCuaGiangVien item;
			count = 0;
			
			System.String sp3179_NamHoc;

			switch ( SelectMethod )
			{
				case ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod.Get:
					results = ViewSoTietCoiThiTieuChuanCuaGiangVienProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod.GetPaged:
					results = ViewSoTietCoiThiTieuChuanCuaGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod.GetAll:
					results = ViewSoTietCoiThiTieuChuanCuaGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod.Find:
					results = ViewSoTietCoiThiTieuChuanCuaGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod.GetByNamHoc:
					sp3179_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = ViewSoTietCoiThiTieuChuanCuaGiangVienProvider.GetByNamHoc(sp3179_NamHoc, StartIndex, PageSize);
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
		
		#endregion Methods
	}

	#region ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByNamHoc method.
		/// </summary>
		GetByNamHoc
	}
	
	#endregion ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod
	
	#region ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource class.
	/// </summary>
	public class ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewSoTietCoiThiTieuChuanCuaGiangVien>
	{
		/// <summary>
		/// Initializes a new instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner class.
		/// </summary>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod SelectMethod
		{
			get { return ((ViewSoTietCoiThiTieuChuanCuaGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceActionList

	/// <summary>
	/// Supports the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner class.
	/// </summary>
	internal class ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceActionList : DesignerActionList
	{
		private ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceActionList(ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienSelectMethod SelectMethod
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

	#endregion ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceActionList

	#endregion ViewSoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner

	#region ViewSoTietCoiThiTieuChuanCuaGiangVienFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSoTietCoiThiTieuChuanCuaGiangVienFilter : SqlFilter<ViewSoTietCoiThiTieuChuanCuaGiangVienColumn>
	{
	}

	#endregion ViewSoTietCoiThiTieuChuanCuaGiangVienFilter

	#region ViewSoTietCoiThiTieuChuanCuaGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSoTietCoiThiTieuChuanCuaGiangVienExpressionBuilder : SqlExpressionBuilder<ViewSoTietCoiThiTieuChuanCuaGiangVienColumn>
	{
	}
	
	#endregion ViewSoTietCoiThiTieuChuanCuaGiangVienExpressionBuilder		
}

