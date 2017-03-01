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
	/// Represents the DataRepository.ViewThoiGianNghiTamThoiCuaGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner))]
	public class ViewThoiGianNghiTamThoiCuaGiangVienDataSource : ReadOnlyDataSource<ViewThoiGianNghiTamThoiCuaGiangVien>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThoiGianNghiTamThoiCuaGiangVienDataSource class.
		/// </summary>
		public ViewThoiGianNghiTamThoiCuaGiangVienDataSource() : base(new ViewThoiGianNghiTamThoiCuaGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThoiGianNghiTamThoiCuaGiangVienDataSourceView used by the ViewThoiGianNghiTamThoiCuaGiangVienDataSource.
		/// </summary>
		protected ViewThoiGianNghiTamThoiCuaGiangVienDataSourceView ViewThoiGianNghiTamThoiCuaGiangVienView
		{
			get { return ( View as ViewThoiGianNghiTamThoiCuaGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThoiGianNghiTamThoiCuaGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod SelectMethod
		{
			get
			{
				ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod selectMethod = ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThoiGianNghiTamThoiCuaGiangVienDataSourceView class that is to be
		/// used by the ViewThoiGianNghiTamThoiCuaGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThoiGianNghiTamThoiCuaGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThoiGianNghiTamThoiCuaGiangVien, Object> GetNewDataSourceView()
		{
			return new ViewThoiGianNghiTamThoiCuaGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThoiGianNghiTamThoiCuaGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThoiGianNghiTamThoiCuaGiangVienDataSourceView : ReadOnlyDataSourceView<ViewThoiGianNghiTamThoiCuaGiangVien>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThoiGianNghiTamThoiCuaGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThoiGianNghiTamThoiCuaGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThoiGianNghiTamThoiCuaGiangVienDataSourceView(ViewThoiGianNghiTamThoiCuaGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThoiGianNghiTamThoiCuaGiangVienDataSource ViewThoiGianNghiTamThoiCuaGiangVienOwner
		{
			get { return Owner as ViewThoiGianNghiTamThoiCuaGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod SelectMethod
		{
			get { return ViewThoiGianNghiTamThoiCuaGiangVienOwner.SelectMethod; }
			set { ViewThoiGianNghiTamThoiCuaGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThoiGianNghiTamThoiCuaGiangVienService ViewThoiGianNghiTamThoiCuaGiangVienProvider
		{
			get { return Provider as ViewThoiGianNghiTamThoiCuaGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThoiGianNghiTamThoiCuaGiangVien> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThoiGianNghiTamThoiCuaGiangVien> results = null;
			// ViewThoiGianNghiTamThoiCuaGiangVien item;
			count = 0;
			
			System.String sp1109_NamHoc;
			System.String sp1110_NamHoc;
			System.String sp1110_HocKy;

			switch ( SelectMethod )
			{
				case ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod.Get:
					results = ViewThoiGianNghiTamThoiCuaGiangVienProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod.GetPaged:
					results = ViewThoiGianNghiTamThoiCuaGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod.GetAll:
					results = ViewThoiGianNghiTamThoiCuaGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod.Find:
					results = ViewThoiGianNghiTamThoiCuaGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod.GetByNamHoc:
					sp1109_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = ViewThoiGianNghiTamThoiCuaGiangVienProvider.GetByNamHoc(sp1109_NamHoc, StartIndex, PageSize);
					break;
				case ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod.GetByNamHocHocKy:
					sp1110_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1110_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewThoiGianNghiTamThoiCuaGiangVienProvider.GetByNamHocHocKy(sp1110_NamHoc, sp1110_HocKy, StartIndex, PageSize);
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

	#region ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThoiGianNghiTamThoiCuaGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod
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
		GetByNamHoc,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod
	
	#region ViewThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThoiGianNghiTamThoiCuaGiangVienDataSource class.
	/// </summary>
	public class ViewThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThoiGianNghiTamThoiCuaGiangVien>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner class.
		/// </summary>
		public ViewThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod SelectMethod
		{
			get { return ((ViewThoiGianNghiTamThoiCuaGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThoiGianNghiTamThoiCuaGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThoiGianNghiTamThoiCuaGiangVienDataSourceActionList

	/// <summary>
	/// Supports the ViewThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner class.
	/// </summary>
	internal class ViewThoiGianNghiTamThoiCuaGiangVienDataSourceActionList : DesignerActionList
	{
		private ViewThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThoiGianNghiTamThoiCuaGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThoiGianNghiTamThoiCuaGiangVienDataSourceActionList(ViewThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThoiGianNghiTamThoiCuaGiangVienSelectMethod SelectMethod
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

	#endregion ViewThoiGianNghiTamThoiCuaGiangVienDataSourceActionList

	#endregion ViewThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner

	#region ViewThoiGianNghiTamThoiCuaGiangVienFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThoiGianNghiTamThoiCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThoiGianNghiTamThoiCuaGiangVienFilter : SqlFilter<ViewThoiGianNghiTamThoiCuaGiangVienColumn>
	{
	}

	#endregion ViewThoiGianNghiTamThoiCuaGiangVienFilter

	#region ViewThoiGianNghiTamThoiCuaGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThoiGianNghiTamThoiCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThoiGianNghiTamThoiCuaGiangVienExpressionBuilder : SqlExpressionBuilder<ViewThoiGianNghiTamThoiCuaGiangVienColumn>
	{
	}
	
	#endregion ViewThoiGianNghiTamThoiCuaGiangVienExpressionBuilder		
}

