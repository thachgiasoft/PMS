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
	/// Represents the DataRepository.ViewTietNghiaVuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewTietNghiaVuDataSourceDesigner))]
	public class ViewTietNghiaVuDataSource : ReadOnlyDataSource<ViewTietNghiaVu>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuDataSource class.
		/// </summary>
		public ViewTietNghiaVuDataSource() : base(new ViewTietNghiaVuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewTietNghiaVuDataSourceView used by the ViewTietNghiaVuDataSource.
		/// </summary>
		protected ViewTietNghiaVuDataSourceView ViewTietNghiaVuView
		{
			get { return ( View as ViewTietNghiaVuDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewTietNghiaVuDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewTietNghiaVuSelectMethod SelectMethod
		{
			get
			{
				ViewTietNghiaVuSelectMethod selectMethod = ViewTietNghiaVuSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewTietNghiaVuSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewTietNghiaVuDataSourceView class that is to be
		/// used by the ViewTietNghiaVuDataSource.
		/// </summary>
		/// <returns>An instance of the ViewTietNghiaVuDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewTietNghiaVu, Object> GetNewDataSourceView()
		{
			return new ViewTietNghiaVuDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewTietNghiaVuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewTietNghiaVuDataSourceView : ReadOnlyDataSourceView<ViewTietNghiaVu>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewTietNghiaVuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewTietNghiaVuDataSourceView(ViewTietNghiaVuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewTietNghiaVuDataSource ViewTietNghiaVuOwner
		{
			get { return Owner as ViewTietNghiaVuDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewTietNghiaVuSelectMethod SelectMethod
		{
			get { return ViewTietNghiaVuOwner.SelectMethod; }
			set { ViewTietNghiaVuOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewTietNghiaVuService ViewTietNghiaVuProvider
		{
			get { return Provider as ViewTietNghiaVuService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewTietNghiaVu> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewTietNghiaVu> results = null;
			// ViewTietNghiaVu item;
			count = 0;
			
			System.String sp3217_NamHoc;
			System.String sp3217_HocKy;

			switch ( SelectMethod )
			{
				case ViewTietNghiaVuSelectMethod.Get:
					results = ViewTietNghiaVuProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewTietNghiaVuSelectMethod.GetPaged:
					results = ViewTietNghiaVuProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewTietNghiaVuSelectMethod.GetAll:
					results = ViewTietNghiaVuProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewTietNghiaVuSelectMethod.Find:
					results = ViewTietNghiaVuProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewTietNghiaVuSelectMethod.GetByNamHocHocKy:
					sp3217_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3217_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewTietNghiaVuProvider.GetByNamHocHocKy(sp3217_NamHoc, sp3217_HocKy, StartIndex, PageSize);
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

	#region ViewTietNghiaVuSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewTietNghiaVuDataSource.SelectMethod property.
	/// </summary>
	public enum ViewTietNghiaVuSelectMethod
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
		GetByNamHocHocKy
	}
	
	#endregion ViewTietNghiaVuSelectMethod
	
	#region ViewTietNghiaVuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewTietNghiaVuDataSource class.
	/// </summary>
	public class ViewTietNghiaVuDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewTietNghiaVu>
	{
		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuDataSourceDesigner class.
		/// </summary>
		public ViewTietNghiaVuDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewTietNghiaVuSelectMethod SelectMethod
		{
			get { return ((ViewTietNghiaVuDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewTietNghiaVuDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewTietNghiaVuDataSourceActionList

	/// <summary>
	/// Supports the ViewTietNghiaVuDataSourceDesigner class.
	/// </summary>
	internal class ViewTietNghiaVuDataSourceActionList : DesignerActionList
	{
		private ViewTietNghiaVuDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewTietNghiaVuDataSourceActionList(ViewTietNghiaVuDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewTietNghiaVuSelectMethod SelectMethod
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

	#endregion ViewTietNghiaVuDataSourceActionList

	#endregion ViewTietNghiaVuDataSourceDesigner

	#region ViewTietNghiaVuFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietNghiaVuFilter : SqlFilter<ViewTietNghiaVuColumn>
	{
	}

	#endregion ViewTietNghiaVuFilter

	#region ViewTietNghiaVuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietNghiaVuExpressionBuilder : SqlExpressionBuilder<ViewTietNghiaVuColumn>
	{
	}
	
	#endregion ViewTietNghiaVuExpressionBuilder		
}

