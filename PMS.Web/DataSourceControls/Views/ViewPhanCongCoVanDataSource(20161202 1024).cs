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
	/// Represents the DataRepository.ViewPhanCongCoVanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewPhanCongCoVanDataSourceDesigner))]
	public class ViewPhanCongCoVanDataSource : ReadOnlyDataSource<ViewPhanCongCoVan>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongCoVanDataSource class.
		/// </summary>
		public ViewPhanCongCoVanDataSource() : base(new ViewPhanCongCoVanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewPhanCongCoVanDataSourceView used by the ViewPhanCongCoVanDataSource.
		/// </summary>
		protected ViewPhanCongCoVanDataSourceView ViewPhanCongCoVanView
		{
			get { return ( View as ViewPhanCongCoVanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewPhanCongCoVanDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewPhanCongCoVanSelectMethod SelectMethod
		{
			get
			{
				ViewPhanCongCoVanSelectMethod selectMethod = ViewPhanCongCoVanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewPhanCongCoVanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewPhanCongCoVanDataSourceView class that is to be
		/// used by the ViewPhanCongCoVanDataSource.
		/// </summary>
		/// <returns>An instance of the ViewPhanCongCoVanDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewPhanCongCoVan, Object> GetNewDataSourceView()
		{
			return new ViewPhanCongCoVanDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewPhanCongCoVanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewPhanCongCoVanDataSourceView : ReadOnlyDataSourceView<ViewPhanCongCoVan>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongCoVanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewPhanCongCoVanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewPhanCongCoVanDataSourceView(ViewPhanCongCoVanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewPhanCongCoVanDataSource ViewPhanCongCoVanOwner
		{
			get { return Owner as ViewPhanCongCoVanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewPhanCongCoVanSelectMethod SelectMethod
		{
			get { return ViewPhanCongCoVanOwner.SelectMethod; }
			set { ViewPhanCongCoVanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewPhanCongCoVanService ViewPhanCongCoVanProvider
		{
			get { return Provider as ViewPhanCongCoVanService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewPhanCongCoVan> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewPhanCongCoVan> results = null;
			// ViewPhanCongCoVan item;
			count = 0;
			
			System.String sp3164_NamHoc;
			System.String sp3164_HocKy;
			System.String sp3163_MaDonVi;
			System.String sp3163_NamHoc;
			System.String sp3163_HocKy;

			switch ( SelectMethod )
			{
				case ViewPhanCongCoVanSelectMethod.Get:
					results = ViewPhanCongCoVanProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewPhanCongCoVanSelectMethod.GetPaged:
					results = ViewPhanCongCoVanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewPhanCongCoVanSelectMethod.GetAll:
					results = ViewPhanCongCoVanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewPhanCongCoVanSelectMethod.Find:
					results = ViewPhanCongCoVanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewPhanCongCoVanSelectMethod.GetByNamHocHocKy:
					sp3164_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3164_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewPhanCongCoVanProvider.GetByNamHocHocKy(sp3164_NamHoc, sp3164_HocKy, StartIndex, PageSize);
					break;
				case ViewPhanCongCoVanSelectMethod.GetByMaDonViNamHocHocKy:
					sp3163_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp3163_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3163_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewPhanCongCoVanProvider.GetByMaDonViNamHocHocKy(sp3163_MaDonVi, sp3163_NamHoc, sp3163_HocKy, StartIndex, PageSize);
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

	#region ViewPhanCongCoVanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewPhanCongCoVanDataSource.SelectMethod property.
	/// </summary>
	public enum ViewPhanCongCoVanSelectMethod
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
		/// Represents the GetByMaDonViNamHocHocKy method.
		/// </summary>
		GetByMaDonViNamHocHocKy
	}
	
	#endregion ViewPhanCongCoVanSelectMethod
	
	#region ViewPhanCongCoVanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewPhanCongCoVanDataSource class.
	/// </summary>
	public class ViewPhanCongCoVanDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewPhanCongCoVan>
	{
		/// <summary>
		/// Initializes a new instance of the ViewPhanCongCoVanDataSourceDesigner class.
		/// </summary>
		public ViewPhanCongCoVanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewPhanCongCoVanSelectMethod SelectMethod
		{
			get { return ((ViewPhanCongCoVanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewPhanCongCoVanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewPhanCongCoVanDataSourceActionList

	/// <summary>
	/// Supports the ViewPhanCongCoVanDataSourceDesigner class.
	/// </summary>
	internal class ViewPhanCongCoVanDataSourceActionList : DesignerActionList
	{
		private ViewPhanCongCoVanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongCoVanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewPhanCongCoVanDataSourceActionList(ViewPhanCongCoVanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewPhanCongCoVanSelectMethod SelectMethod
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

	#endregion ViewPhanCongCoVanDataSourceActionList

	#endregion ViewPhanCongCoVanDataSourceDesigner

	#region ViewPhanCongCoVanFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongCoVan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanCongCoVanFilter : SqlFilter<ViewPhanCongCoVanColumn>
	{
	}

	#endregion ViewPhanCongCoVanFilter

	#region ViewPhanCongCoVanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongCoVan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanCongCoVanExpressionBuilder : SqlExpressionBuilder<ViewPhanCongCoVanColumn>
	{
	}
	
	#endregion ViewPhanCongCoVanExpressionBuilder		
}

