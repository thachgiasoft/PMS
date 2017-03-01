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
	/// Represents the DataRepository.ViewKcqHopDongThinhGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKcqHopDongThinhGiangDataSourceDesigner))]
	public class ViewKcqHopDongThinhGiangDataSource : ReadOnlyDataSource<ViewKcqHopDongThinhGiang>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqHopDongThinhGiangDataSource class.
		/// </summary>
		public ViewKcqHopDongThinhGiangDataSource() : base(new ViewKcqHopDongThinhGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKcqHopDongThinhGiangDataSourceView used by the ViewKcqHopDongThinhGiangDataSource.
		/// </summary>
		protected ViewKcqHopDongThinhGiangDataSourceView ViewKcqHopDongThinhGiangView
		{
			get { return ( View as ViewKcqHopDongThinhGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKcqHopDongThinhGiangDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKcqHopDongThinhGiangSelectMethod SelectMethod
		{
			get
			{
				ViewKcqHopDongThinhGiangSelectMethod selectMethod = ViewKcqHopDongThinhGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKcqHopDongThinhGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKcqHopDongThinhGiangDataSourceView class that is to be
		/// used by the ViewKcqHopDongThinhGiangDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKcqHopDongThinhGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKcqHopDongThinhGiang, Object> GetNewDataSourceView()
		{
			return new ViewKcqHopDongThinhGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKcqHopDongThinhGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKcqHopDongThinhGiangDataSourceView : ReadOnlyDataSourceView<ViewKcqHopDongThinhGiang>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqHopDongThinhGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKcqHopDongThinhGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKcqHopDongThinhGiangDataSourceView(ViewKcqHopDongThinhGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKcqHopDongThinhGiangDataSource ViewKcqHopDongThinhGiangOwner
		{
			get { return Owner as ViewKcqHopDongThinhGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKcqHopDongThinhGiangSelectMethod SelectMethod
		{
			get { return ViewKcqHopDongThinhGiangOwner.SelectMethod; }
			set { ViewKcqHopDongThinhGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKcqHopDongThinhGiangService ViewKcqHopDongThinhGiangProvider
		{
			get { return Provider as ViewKcqHopDongThinhGiangService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKcqHopDongThinhGiang> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKcqHopDongThinhGiang> results = null;
			// ViewKcqHopDongThinhGiang item;
			count = 0;
			
			System.String sp983_NamHoc;
			System.String sp983_HocKy;

			switch ( SelectMethod )
			{
				case ViewKcqHopDongThinhGiangSelectMethod.Get:
					results = ViewKcqHopDongThinhGiangProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKcqHopDongThinhGiangSelectMethod.GetPaged:
					results = ViewKcqHopDongThinhGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKcqHopDongThinhGiangSelectMethod.GetAll:
					results = ViewKcqHopDongThinhGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKcqHopDongThinhGiangSelectMethod.Find:
					results = ViewKcqHopDongThinhGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKcqHopDongThinhGiangSelectMethod.GetByNamHocHocKy:
					sp983_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp983_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewKcqHopDongThinhGiangProvider.GetByNamHocHocKy(sp983_NamHoc, sp983_HocKy, StartIndex, PageSize);
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

	#region ViewKcqHopDongThinhGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKcqHopDongThinhGiangDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKcqHopDongThinhGiangSelectMethod
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
	
	#endregion ViewKcqHopDongThinhGiangSelectMethod
	
	#region ViewKcqHopDongThinhGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKcqHopDongThinhGiangDataSource class.
	/// </summary>
	public class ViewKcqHopDongThinhGiangDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKcqHopDongThinhGiang>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKcqHopDongThinhGiangDataSourceDesigner class.
		/// </summary>
		public ViewKcqHopDongThinhGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKcqHopDongThinhGiangSelectMethod SelectMethod
		{
			get { return ((ViewKcqHopDongThinhGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKcqHopDongThinhGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKcqHopDongThinhGiangDataSourceActionList

	/// <summary>
	/// Supports the ViewKcqHopDongThinhGiangDataSourceDesigner class.
	/// </summary>
	internal class ViewKcqHopDongThinhGiangDataSourceActionList : DesignerActionList
	{
		private ViewKcqHopDongThinhGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKcqHopDongThinhGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKcqHopDongThinhGiangDataSourceActionList(ViewKcqHopDongThinhGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKcqHopDongThinhGiangSelectMethod SelectMethod
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

	#endregion ViewKcqHopDongThinhGiangDataSourceActionList

	#endregion ViewKcqHopDongThinhGiangDataSourceDesigner

	#region ViewKcqHopDongThinhGiangFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqHopDongThinhGiangFilter : SqlFilter<ViewKcqHopDongThinhGiangColumn>
	{
	}

	#endregion ViewKcqHopDongThinhGiangFilter

	#region ViewKcqHopDongThinhGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqHopDongThinhGiangExpressionBuilder : SqlExpressionBuilder<ViewKcqHopDongThinhGiangColumn>
	{
	}
	
	#endregion ViewKcqHopDongThinhGiangExpressionBuilder		
}

