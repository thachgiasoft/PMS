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
	/// Represents the DataRepository.ViewTietNghiaVuTheoNamHocHocKyProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewTietNghiaVuTheoNamHocHocKyDataSourceDesigner))]
	public class ViewTietNghiaVuTheoNamHocHocKyDataSource : ReadOnlyDataSource<ViewTietNghiaVuTheoNamHocHocKy>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuTheoNamHocHocKyDataSource class.
		/// </summary>
		public ViewTietNghiaVuTheoNamHocHocKyDataSource() : base(new ViewTietNghiaVuTheoNamHocHocKyService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewTietNghiaVuTheoNamHocHocKyDataSourceView used by the ViewTietNghiaVuTheoNamHocHocKyDataSource.
		/// </summary>
		protected ViewTietNghiaVuTheoNamHocHocKyDataSourceView ViewTietNghiaVuTheoNamHocHocKyView
		{
			get { return ( View as ViewTietNghiaVuTheoNamHocHocKyDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewTietNghiaVuTheoNamHocHocKyDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewTietNghiaVuTheoNamHocHocKySelectMethod SelectMethod
		{
			get
			{
				ViewTietNghiaVuTheoNamHocHocKySelectMethod selectMethod = ViewTietNghiaVuTheoNamHocHocKySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewTietNghiaVuTheoNamHocHocKySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewTietNghiaVuTheoNamHocHocKyDataSourceView class that is to be
		/// used by the ViewTietNghiaVuTheoNamHocHocKyDataSource.
		/// </summary>
		/// <returns>An instance of the ViewTietNghiaVuTheoNamHocHocKyDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewTietNghiaVuTheoNamHocHocKy, Object> GetNewDataSourceView()
		{
			return new ViewTietNghiaVuTheoNamHocHocKyDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewTietNghiaVuTheoNamHocHocKyDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewTietNghiaVuTheoNamHocHocKyDataSourceView : ReadOnlyDataSourceView<ViewTietNghiaVuTheoNamHocHocKy>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuTheoNamHocHocKyDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewTietNghiaVuTheoNamHocHocKyDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewTietNghiaVuTheoNamHocHocKyDataSourceView(ViewTietNghiaVuTheoNamHocHocKyDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewTietNghiaVuTheoNamHocHocKyDataSource ViewTietNghiaVuTheoNamHocHocKyOwner
		{
			get { return Owner as ViewTietNghiaVuTheoNamHocHocKyDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewTietNghiaVuTheoNamHocHocKySelectMethod SelectMethod
		{
			get { return ViewTietNghiaVuTheoNamHocHocKyOwner.SelectMethod; }
			set { ViewTietNghiaVuTheoNamHocHocKyOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewTietNghiaVuTheoNamHocHocKyService ViewTietNghiaVuTheoNamHocHocKyProvider
		{
			get { return Provider as ViewTietNghiaVuTheoNamHocHocKyService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewTietNghiaVuTheoNamHocHocKy> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewTietNghiaVuTheoNamHocHocKy> results = null;
			// ViewTietNghiaVuTheoNamHocHocKy item;
			count = 0;
			
			System.String sp1124_NamHoc;
			System.String sp1124_HocKy;
			System.String sp1121_NamHoc;

			switch ( SelectMethod )
			{
				case ViewTietNghiaVuTheoNamHocHocKySelectMethod.Get:
					results = ViewTietNghiaVuTheoNamHocHocKyProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewTietNghiaVuTheoNamHocHocKySelectMethod.GetPaged:
					results = ViewTietNghiaVuTheoNamHocHocKyProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewTietNghiaVuTheoNamHocHocKySelectMethod.GetAll:
					results = ViewTietNghiaVuTheoNamHocHocKyProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewTietNghiaVuTheoNamHocHocKySelectMethod.Find:
					results = ViewTietNghiaVuTheoNamHocHocKyProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewTietNghiaVuTheoNamHocHocKySelectMethod.GetByNamHocHocKy:
					sp1124_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1124_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewTietNghiaVuTheoNamHocHocKyProvider.GetByNamHocHocKy(sp1124_NamHoc, sp1124_HocKy, StartIndex, PageSize);
					break;
				case ViewTietNghiaVuTheoNamHocHocKySelectMethod.GetByNamHoc:
					sp1121_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = ViewTietNghiaVuTheoNamHocHocKyProvider.GetByNamHoc(sp1121_NamHoc, StartIndex, PageSize);
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

	#region ViewTietNghiaVuTheoNamHocHocKySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewTietNghiaVuTheoNamHocHocKyDataSource.SelectMethod property.
	/// </summary>
	public enum ViewTietNghiaVuTheoNamHocHocKySelectMethod
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
		GetByNamHoc
	}
	
	#endregion ViewTietNghiaVuTheoNamHocHocKySelectMethod
	
	#region ViewTietNghiaVuTheoNamHocHocKyDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewTietNghiaVuTheoNamHocHocKyDataSource class.
	/// </summary>
	public class ViewTietNghiaVuTheoNamHocHocKyDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewTietNghiaVuTheoNamHocHocKy>
	{
		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuTheoNamHocHocKyDataSourceDesigner class.
		/// </summary>
		public ViewTietNghiaVuTheoNamHocHocKyDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewTietNghiaVuTheoNamHocHocKySelectMethod SelectMethod
		{
			get { return ((ViewTietNghiaVuTheoNamHocHocKyDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewTietNghiaVuTheoNamHocHocKyDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewTietNghiaVuTheoNamHocHocKyDataSourceActionList

	/// <summary>
	/// Supports the ViewTietNghiaVuTheoNamHocHocKyDataSourceDesigner class.
	/// </summary>
	internal class ViewTietNghiaVuTheoNamHocHocKyDataSourceActionList : DesignerActionList
	{
		private ViewTietNghiaVuTheoNamHocHocKyDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuTheoNamHocHocKyDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewTietNghiaVuTheoNamHocHocKyDataSourceActionList(ViewTietNghiaVuTheoNamHocHocKyDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewTietNghiaVuTheoNamHocHocKySelectMethod SelectMethod
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

	#endregion ViewTietNghiaVuTheoNamHocHocKyDataSourceActionList

	#endregion ViewTietNghiaVuTheoNamHocHocKyDataSourceDesigner

	#region ViewTietNghiaVuTheoNamHocHocKyFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNghiaVuTheoNamHocHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietNghiaVuTheoNamHocHocKyFilter : SqlFilter<ViewTietNghiaVuTheoNamHocHocKyColumn>
	{
	}

	#endregion ViewTietNghiaVuTheoNamHocHocKyFilter

	#region ViewTietNghiaVuTheoNamHocHocKyExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNghiaVuTheoNamHocHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietNghiaVuTheoNamHocHocKyExpressionBuilder : SqlExpressionBuilder<ViewTietNghiaVuTheoNamHocHocKyColumn>
	{
	}
	
	#endregion ViewTietNghiaVuTheoNamHocHocKyExpressionBuilder		
}

