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
	/// Represents the DataRepository.ViewThoiGianLamViecCuaNhanVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThoiGianLamViecCuaNhanVienDataSourceDesigner))]
	public class ViewThoiGianLamViecCuaNhanVienDataSource : ReadOnlyDataSource<ViewThoiGianLamViecCuaNhanVien>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThoiGianLamViecCuaNhanVienDataSource class.
		/// </summary>
		public ViewThoiGianLamViecCuaNhanVienDataSource() : base(new ViewThoiGianLamViecCuaNhanVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThoiGianLamViecCuaNhanVienDataSourceView used by the ViewThoiGianLamViecCuaNhanVienDataSource.
		/// </summary>
		protected ViewThoiGianLamViecCuaNhanVienDataSourceView ViewThoiGianLamViecCuaNhanVienView
		{
			get { return ( View as ViewThoiGianLamViecCuaNhanVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThoiGianLamViecCuaNhanVienDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThoiGianLamViecCuaNhanVienSelectMethod SelectMethod
		{
			get
			{
				ViewThoiGianLamViecCuaNhanVienSelectMethod selectMethod = ViewThoiGianLamViecCuaNhanVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThoiGianLamViecCuaNhanVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThoiGianLamViecCuaNhanVienDataSourceView class that is to be
		/// used by the ViewThoiGianLamViecCuaNhanVienDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThoiGianLamViecCuaNhanVienDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThoiGianLamViecCuaNhanVien, Object> GetNewDataSourceView()
		{
			return new ViewThoiGianLamViecCuaNhanVienDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThoiGianLamViecCuaNhanVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThoiGianLamViecCuaNhanVienDataSourceView : ReadOnlyDataSourceView<ViewThoiGianLamViecCuaNhanVien>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThoiGianLamViecCuaNhanVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThoiGianLamViecCuaNhanVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThoiGianLamViecCuaNhanVienDataSourceView(ViewThoiGianLamViecCuaNhanVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThoiGianLamViecCuaNhanVienDataSource ViewThoiGianLamViecCuaNhanVienOwner
		{
			get { return Owner as ViewThoiGianLamViecCuaNhanVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThoiGianLamViecCuaNhanVienSelectMethod SelectMethod
		{
			get { return ViewThoiGianLamViecCuaNhanVienOwner.SelectMethod; }
			set { ViewThoiGianLamViecCuaNhanVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThoiGianLamViecCuaNhanVienService ViewThoiGianLamViecCuaNhanVienProvider
		{
			get { return Provider as ViewThoiGianLamViecCuaNhanVienService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThoiGianLamViecCuaNhanVien> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThoiGianLamViecCuaNhanVien> results = null;
			// ViewThoiGianLamViecCuaNhanVien item;
			count = 0;
			
			System.String sp3204_NamHoc;
			System.String sp3205_NamHoc;
			System.String sp3205_HocKy;

			switch ( SelectMethod )
			{
				case ViewThoiGianLamViecCuaNhanVienSelectMethod.Get:
					results = ViewThoiGianLamViecCuaNhanVienProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThoiGianLamViecCuaNhanVienSelectMethod.GetPaged:
					results = ViewThoiGianLamViecCuaNhanVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThoiGianLamViecCuaNhanVienSelectMethod.GetAll:
					results = ViewThoiGianLamViecCuaNhanVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThoiGianLamViecCuaNhanVienSelectMethod.Find:
					results = ViewThoiGianLamViecCuaNhanVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThoiGianLamViecCuaNhanVienSelectMethod.GetByNamHoc:
					sp3204_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = ViewThoiGianLamViecCuaNhanVienProvider.GetByNamHoc(sp3204_NamHoc, StartIndex, PageSize);
					break;
				case ViewThoiGianLamViecCuaNhanVienSelectMethod.GetByNamHocHocKy:
					sp3205_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3205_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewThoiGianLamViecCuaNhanVienProvider.GetByNamHocHocKy(sp3205_NamHoc, sp3205_HocKy, StartIndex, PageSize);
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

	#region ViewThoiGianLamViecCuaNhanVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThoiGianLamViecCuaNhanVienDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThoiGianLamViecCuaNhanVienSelectMethod
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
	
	#endregion ViewThoiGianLamViecCuaNhanVienSelectMethod
	
	#region ViewThoiGianLamViecCuaNhanVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThoiGianLamViecCuaNhanVienDataSource class.
	/// </summary>
	public class ViewThoiGianLamViecCuaNhanVienDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThoiGianLamViecCuaNhanVien>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThoiGianLamViecCuaNhanVienDataSourceDesigner class.
		/// </summary>
		public ViewThoiGianLamViecCuaNhanVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThoiGianLamViecCuaNhanVienSelectMethod SelectMethod
		{
			get { return ((ViewThoiGianLamViecCuaNhanVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThoiGianLamViecCuaNhanVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThoiGianLamViecCuaNhanVienDataSourceActionList

	/// <summary>
	/// Supports the ViewThoiGianLamViecCuaNhanVienDataSourceDesigner class.
	/// </summary>
	internal class ViewThoiGianLamViecCuaNhanVienDataSourceActionList : DesignerActionList
	{
		private ViewThoiGianLamViecCuaNhanVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThoiGianLamViecCuaNhanVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThoiGianLamViecCuaNhanVienDataSourceActionList(ViewThoiGianLamViecCuaNhanVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThoiGianLamViecCuaNhanVienSelectMethod SelectMethod
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

	#endregion ViewThoiGianLamViecCuaNhanVienDataSourceActionList

	#endregion ViewThoiGianLamViecCuaNhanVienDataSourceDesigner

	#region ViewThoiGianLamViecCuaNhanVienFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThoiGianLamViecCuaNhanVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThoiGianLamViecCuaNhanVienFilter : SqlFilter<ViewThoiGianLamViecCuaNhanVienColumn>
	{
	}

	#endregion ViewThoiGianLamViecCuaNhanVienFilter

	#region ViewThoiGianLamViecCuaNhanVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThoiGianLamViecCuaNhanVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThoiGianLamViecCuaNhanVienExpressionBuilder : SqlExpressionBuilder<ViewThoiGianLamViecCuaNhanVienColumn>
	{
	}
	
	#endregion ViewThoiGianLamViecCuaNhanVienExpressionBuilder		
}

