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
	/// Represents the DataRepository.ViewGiamTruGioChuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewGiamTruGioChuanDataSourceDesigner))]
	public class ViewGiamTruGioChuanDataSource : ReadOnlyDataSource<ViewGiamTruGioChuan>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiamTruGioChuanDataSource class.
		/// </summary>
		public ViewGiamTruGioChuanDataSource() : base(new ViewGiamTruGioChuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewGiamTruGioChuanDataSourceView used by the ViewGiamTruGioChuanDataSource.
		/// </summary>
		protected ViewGiamTruGioChuanDataSourceView ViewGiamTruGioChuanView
		{
			get { return ( View as ViewGiamTruGioChuanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewGiamTruGioChuanDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewGiamTruGioChuanSelectMethod SelectMethod
		{
			get
			{
				ViewGiamTruGioChuanSelectMethod selectMethod = ViewGiamTruGioChuanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewGiamTruGioChuanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewGiamTruGioChuanDataSourceView class that is to be
		/// used by the ViewGiamTruGioChuanDataSource.
		/// </summary>
		/// <returns>An instance of the ViewGiamTruGioChuanDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewGiamTruGioChuan, Object> GetNewDataSourceView()
		{
			return new ViewGiamTruGioChuanDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewGiamTruGioChuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewGiamTruGioChuanDataSourceView : ReadOnlyDataSourceView<ViewGiamTruGioChuan>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiamTruGioChuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewGiamTruGioChuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewGiamTruGioChuanDataSourceView(ViewGiamTruGioChuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewGiamTruGioChuanDataSource ViewGiamTruGioChuanOwner
		{
			get { return Owner as ViewGiamTruGioChuanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewGiamTruGioChuanSelectMethod SelectMethod
		{
			get { return ViewGiamTruGioChuanOwner.SelectMethod; }
			set { ViewGiamTruGioChuanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewGiamTruGioChuanService ViewGiamTruGioChuanProvider
		{
			get { return Provider as ViewGiamTruGioChuanService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewGiamTruGioChuan> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewGiamTruGioChuan> results = null;
			// ViewGiamTruGioChuan item;
			count = 0;
			
			System.String sp953_NamHoc;
			System.String sp953_HocKy;
			System.String sp952_NamHoc;
			System.String sp954_NamHoc;
			System.String sp954_HocKy;
			System.String sp954_MaDonVi;

			switch ( SelectMethod )
			{
				case ViewGiamTruGioChuanSelectMethod.Get:
					results = ViewGiamTruGioChuanProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewGiamTruGioChuanSelectMethod.GetPaged:
					results = ViewGiamTruGioChuanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewGiamTruGioChuanSelectMethod.GetAll:
					results = ViewGiamTruGioChuanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewGiamTruGioChuanSelectMethod.Find:
					results = ViewGiamTruGioChuanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewGiamTruGioChuanSelectMethod.GetByNamHocHocKy:
					sp953_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp953_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewGiamTruGioChuanProvider.GetByNamHocHocKy(sp953_NamHoc, sp953_HocKy, StartIndex, PageSize);
					break;
				case ViewGiamTruGioChuanSelectMethod.GetByNamHoc:
					sp952_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = ViewGiamTruGioChuanProvider.GetByNamHoc(sp952_NamHoc, StartIndex, PageSize);
					break;
				case ViewGiamTruGioChuanSelectMethod.GetByNamHocHocKyKhoaDonVi:
					sp954_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp954_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp954_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewGiamTruGioChuanProvider.GetByNamHocHocKyKhoaDonVi(sp954_NamHoc, sp954_HocKy, sp954_MaDonVi, StartIndex, PageSize);
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

	#region ViewGiamTruGioChuanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewGiamTruGioChuanDataSource.SelectMethod property.
	/// </summary>
	public enum ViewGiamTruGioChuanSelectMethod
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
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHoc method.
		/// </summary>
		GetByNamHoc,
		/// <summary>
		/// Represents the GetByNamHocHocKyKhoaDonVi method.
		/// </summary>
		GetByNamHocHocKyKhoaDonVi
	}
	
	#endregion ViewGiamTruGioChuanSelectMethod
	
	#region ViewGiamTruGioChuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewGiamTruGioChuanDataSource class.
	/// </summary>
	public class ViewGiamTruGioChuanDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewGiamTruGioChuan>
	{
		/// <summary>
		/// Initializes a new instance of the ViewGiamTruGioChuanDataSourceDesigner class.
		/// </summary>
		public ViewGiamTruGioChuanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewGiamTruGioChuanSelectMethod SelectMethod
		{
			get { return ((ViewGiamTruGioChuanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewGiamTruGioChuanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewGiamTruGioChuanDataSourceActionList

	/// <summary>
	/// Supports the ViewGiamTruGioChuanDataSourceDesigner class.
	/// </summary>
	internal class ViewGiamTruGioChuanDataSourceActionList : DesignerActionList
	{
		private ViewGiamTruGioChuanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewGiamTruGioChuanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewGiamTruGioChuanDataSourceActionList(ViewGiamTruGioChuanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewGiamTruGioChuanSelectMethod SelectMethod
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

	#endregion ViewGiamTruGioChuanDataSourceActionList

	#endregion ViewGiamTruGioChuanDataSourceDesigner

	#region ViewGiamTruGioChuanFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiamTruGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiamTruGioChuanFilter : SqlFilter<ViewGiamTruGioChuanColumn>
	{
	}

	#endregion ViewGiamTruGioChuanFilter

	#region ViewGiamTruGioChuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiamTruGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiamTruGioChuanExpressionBuilder : SqlExpressionBuilder<ViewGiamTruGioChuanColumn>
	{
	}
	
	#endregion ViewGiamTruGioChuanExpressionBuilder		
}

