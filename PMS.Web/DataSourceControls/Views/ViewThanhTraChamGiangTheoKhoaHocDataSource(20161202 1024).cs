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
	/// Represents the DataRepository.ViewThanhTraChamGiangTheoKhoaHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThanhTraChamGiangTheoKhoaHocDataSourceDesigner))]
	public class ViewThanhTraChamGiangTheoKhoaHocDataSource : ReadOnlyDataSource<ViewThanhTraChamGiangTheoKhoaHoc>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraChamGiangTheoKhoaHocDataSource class.
		/// </summary>
		public ViewThanhTraChamGiangTheoKhoaHocDataSource() : base(new ViewThanhTraChamGiangTheoKhoaHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThanhTraChamGiangTheoKhoaHocDataSourceView used by the ViewThanhTraChamGiangTheoKhoaHocDataSource.
		/// </summary>
		protected ViewThanhTraChamGiangTheoKhoaHocDataSourceView ViewThanhTraChamGiangTheoKhoaHocView
		{
			get { return ( View as ViewThanhTraChamGiangTheoKhoaHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThanhTraChamGiangTheoKhoaHocDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThanhTraChamGiangTheoKhoaHocSelectMethod SelectMethod
		{
			get
			{
				ViewThanhTraChamGiangTheoKhoaHocSelectMethod selectMethod = ViewThanhTraChamGiangTheoKhoaHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThanhTraChamGiangTheoKhoaHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThanhTraChamGiangTheoKhoaHocDataSourceView class that is to be
		/// used by the ViewThanhTraChamGiangTheoKhoaHocDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThanhTraChamGiangTheoKhoaHocDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThanhTraChamGiangTheoKhoaHoc, Object> GetNewDataSourceView()
		{
			return new ViewThanhTraChamGiangTheoKhoaHocDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThanhTraChamGiangTheoKhoaHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThanhTraChamGiangTheoKhoaHocDataSourceView : ReadOnlyDataSourceView<ViewThanhTraChamGiangTheoKhoaHoc>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraChamGiangTheoKhoaHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThanhTraChamGiangTheoKhoaHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThanhTraChamGiangTheoKhoaHocDataSourceView(ViewThanhTraChamGiangTheoKhoaHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThanhTraChamGiangTheoKhoaHocDataSource ViewThanhTraChamGiangTheoKhoaHocOwner
		{
			get { return Owner as ViewThanhTraChamGiangTheoKhoaHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThanhTraChamGiangTheoKhoaHocSelectMethod SelectMethod
		{
			get { return ViewThanhTraChamGiangTheoKhoaHocOwner.SelectMethod; }
			set { ViewThanhTraChamGiangTheoKhoaHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThanhTraChamGiangTheoKhoaHocService ViewThanhTraChamGiangTheoKhoaHocProvider
		{
			get { return Provider as ViewThanhTraChamGiangTheoKhoaHocService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThanhTraChamGiangTheoKhoaHoc> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThanhTraChamGiangTheoKhoaHoc> results = null;
			// ViewThanhTraChamGiangTheoKhoaHoc item;
			count = 0;
			
			System.String sp3186_NamHoc;
			System.String sp3186_HocKy;

			switch ( SelectMethod )
			{
				case ViewThanhTraChamGiangTheoKhoaHocSelectMethod.Get:
					results = ViewThanhTraChamGiangTheoKhoaHocProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThanhTraChamGiangTheoKhoaHocSelectMethod.GetPaged:
					results = ViewThanhTraChamGiangTheoKhoaHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThanhTraChamGiangTheoKhoaHocSelectMethod.GetAll:
					results = ViewThanhTraChamGiangTheoKhoaHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThanhTraChamGiangTheoKhoaHocSelectMethod.Find:
					results = ViewThanhTraChamGiangTheoKhoaHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThanhTraChamGiangTheoKhoaHocSelectMethod.GetByNamHocHocKy:
					sp3186_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3186_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewThanhTraChamGiangTheoKhoaHocProvider.GetByNamHocHocKy(sp3186_NamHoc, sp3186_HocKy, StartIndex, PageSize);
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

	#region ViewThanhTraChamGiangTheoKhoaHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThanhTraChamGiangTheoKhoaHocDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThanhTraChamGiangTheoKhoaHocSelectMethod
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
	
	#endregion ViewThanhTraChamGiangTheoKhoaHocSelectMethod
	
	#region ViewThanhTraChamGiangTheoKhoaHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThanhTraChamGiangTheoKhoaHocDataSource class.
	/// </summary>
	public class ViewThanhTraChamGiangTheoKhoaHocDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThanhTraChamGiangTheoKhoaHoc>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThanhTraChamGiangTheoKhoaHocDataSourceDesigner class.
		/// </summary>
		public ViewThanhTraChamGiangTheoKhoaHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThanhTraChamGiangTheoKhoaHocSelectMethod SelectMethod
		{
			get { return ((ViewThanhTraChamGiangTheoKhoaHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThanhTraChamGiangTheoKhoaHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThanhTraChamGiangTheoKhoaHocDataSourceActionList

	/// <summary>
	/// Supports the ViewThanhTraChamGiangTheoKhoaHocDataSourceDesigner class.
	/// </summary>
	internal class ViewThanhTraChamGiangTheoKhoaHocDataSourceActionList : DesignerActionList
	{
		private ViewThanhTraChamGiangTheoKhoaHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraChamGiangTheoKhoaHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThanhTraChamGiangTheoKhoaHocDataSourceActionList(ViewThanhTraChamGiangTheoKhoaHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThanhTraChamGiangTheoKhoaHocSelectMethod SelectMethod
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

	#endregion ViewThanhTraChamGiangTheoKhoaHocDataSourceActionList

	#endregion ViewThanhTraChamGiangTheoKhoaHocDataSourceDesigner

	#region ViewThanhTraChamGiangTheoKhoaHocFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraChamGiangTheoKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraChamGiangTheoKhoaHocFilter : SqlFilter<ViewThanhTraChamGiangTheoKhoaHocColumn>
	{
	}

	#endregion ViewThanhTraChamGiangTheoKhoaHocFilter

	#region ViewThanhTraChamGiangTheoKhoaHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraChamGiangTheoKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraChamGiangTheoKhoaHocExpressionBuilder : SqlExpressionBuilder<ViewThanhTraChamGiangTheoKhoaHocColumn>
	{
	}
	
	#endregion ViewThanhTraChamGiangTheoKhoaHocExpressionBuilder		
}

