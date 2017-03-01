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
	/// Represents the DataRepository.ViewMonXepLichChuNhatKhongTinhHeSoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner))]
	public class ViewMonXepLichChuNhatKhongTinhHeSoDataSource : ReadOnlyDataSource<ViewMonXepLichChuNhatKhongTinhHeSo>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonXepLichChuNhatKhongTinhHeSoDataSource class.
		/// </summary>
		public ViewMonXepLichChuNhatKhongTinhHeSoDataSource() : base(new ViewMonXepLichChuNhatKhongTinhHeSoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewMonXepLichChuNhatKhongTinhHeSoDataSourceView used by the ViewMonXepLichChuNhatKhongTinhHeSoDataSource.
		/// </summary>
		protected ViewMonXepLichChuNhatKhongTinhHeSoDataSourceView ViewMonXepLichChuNhatKhongTinhHeSoView
		{
			get { return ( View as ViewMonXepLichChuNhatKhongTinhHeSoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewMonXepLichChuNhatKhongTinhHeSoDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod SelectMethod
		{
			get
			{
				ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod selectMethod = ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewMonXepLichChuNhatKhongTinhHeSoDataSourceView class that is to be
		/// used by the ViewMonXepLichChuNhatKhongTinhHeSoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewMonXepLichChuNhatKhongTinhHeSoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewMonXepLichChuNhatKhongTinhHeSo, Object> GetNewDataSourceView()
		{
			return new ViewMonXepLichChuNhatKhongTinhHeSoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewMonXepLichChuNhatKhongTinhHeSoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewMonXepLichChuNhatKhongTinhHeSoDataSourceView : ReadOnlyDataSourceView<ViewMonXepLichChuNhatKhongTinhHeSo>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonXepLichChuNhatKhongTinhHeSoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewMonXepLichChuNhatKhongTinhHeSoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewMonXepLichChuNhatKhongTinhHeSoDataSourceView(ViewMonXepLichChuNhatKhongTinhHeSoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewMonXepLichChuNhatKhongTinhHeSoDataSource ViewMonXepLichChuNhatKhongTinhHeSoOwner
		{
			get { return Owner as ViewMonXepLichChuNhatKhongTinhHeSoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod SelectMethod
		{
			get { return ViewMonXepLichChuNhatKhongTinhHeSoOwner.SelectMethod; }
			set { ViewMonXepLichChuNhatKhongTinhHeSoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewMonXepLichChuNhatKhongTinhHeSoService ViewMonXepLichChuNhatKhongTinhHeSoProvider
		{
			get { return Provider as ViewMonXepLichChuNhatKhongTinhHeSoService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewMonXepLichChuNhatKhongTinhHeSo> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewMonXepLichChuNhatKhongTinhHeSo> results = null;
			// ViewMonXepLichChuNhatKhongTinhHeSo item;
			count = 0;
			
			System.String sp3158_NamHoc;
			System.String sp3158_HocKy;

			switch ( SelectMethod )
			{
				case ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod.Get:
					results = ViewMonXepLichChuNhatKhongTinhHeSoProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod.GetPaged:
					results = ViewMonXepLichChuNhatKhongTinhHeSoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod.GetAll:
					results = ViewMonXepLichChuNhatKhongTinhHeSoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod.Find:
					results = ViewMonXepLichChuNhatKhongTinhHeSoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod.GetByNamHocHocKy:
					sp3158_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3158_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewMonXepLichChuNhatKhongTinhHeSoProvider.GetByNamHocHocKy(sp3158_NamHoc, sp3158_HocKy, StartIndex, PageSize);
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

	#region ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewMonXepLichChuNhatKhongTinhHeSoDataSource.SelectMethod property.
	/// </summary>
	public enum ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod
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
	
	#endregion ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod
	
	#region ViewMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewMonXepLichChuNhatKhongTinhHeSoDataSource class.
	/// </summary>
	public class ViewMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewMonXepLichChuNhatKhongTinhHeSo>
	{
		/// <summary>
		/// Initializes a new instance of the ViewMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner class.
		/// </summary>
		public ViewMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod SelectMethod
		{
			get { return ((ViewMonXepLichChuNhatKhongTinhHeSoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewMonXepLichChuNhatKhongTinhHeSoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewMonXepLichChuNhatKhongTinhHeSoDataSourceActionList

	/// <summary>
	/// Supports the ViewMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner class.
	/// </summary>
	internal class ViewMonXepLichChuNhatKhongTinhHeSoDataSourceActionList : DesignerActionList
	{
		private ViewMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewMonXepLichChuNhatKhongTinhHeSoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewMonXepLichChuNhatKhongTinhHeSoDataSourceActionList(ViewMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewMonXepLichChuNhatKhongTinhHeSoSelectMethod SelectMethod
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

	#endregion ViewMonXepLichChuNhatKhongTinhHeSoDataSourceActionList

	#endregion ViewMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner

	#region ViewMonXepLichChuNhatKhongTinhHeSoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonXepLichChuNhatKhongTinhHeSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonXepLichChuNhatKhongTinhHeSoFilter : SqlFilter<ViewMonXepLichChuNhatKhongTinhHeSoColumn>
	{
	}

	#endregion ViewMonXepLichChuNhatKhongTinhHeSoFilter

	#region ViewMonXepLichChuNhatKhongTinhHeSoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonXepLichChuNhatKhongTinhHeSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonXepLichChuNhatKhongTinhHeSoExpressionBuilder : SqlExpressionBuilder<ViewMonXepLichChuNhatKhongTinhHeSoColumn>
	{
	}
	
	#endregion ViewMonXepLichChuNhatKhongTinhHeSoExpressionBuilder		
}

