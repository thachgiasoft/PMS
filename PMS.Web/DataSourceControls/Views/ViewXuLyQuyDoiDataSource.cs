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
	/// Represents the DataRepository.ViewXuLyQuyDoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewXuLyQuyDoiDataSourceDesigner))]
	public class ViewXuLyQuyDoiDataSource : ReadOnlyDataSource<ViewXuLyQuyDoi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewXuLyQuyDoiDataSource class.
		/// </summary>
		public ViewXuLyQuyDoiDataSource() : base(new ViewXuLyQuyDoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewXuLyQuyDoiDataSourceView used by the ViewXuLyQuyDoiDataSource.
		/// </summary>
		protected ViewXuLyQuyDoiDataSourceView ViewXuLyQuyDoiView
		{
			get { return ( View as ViewXuLyQuyDoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewXuLyQuyDoiDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewXuLyQuyDoiSelectMethod SelectMethod
		{
			get
			{
				ViewXuLyQuyDoiSelectMethod selectMethod = ViewXuLyQuyDoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewXuLyQuyDoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewXuLyQuyDoiDataSourceView class that is to be
		/// used by the ViewXuLyQuyDoiDataSource.
		/// </summary>
		/// <returns>An instance of the ViewXuLyQuyDoiDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewXuLyQuyDoi, Object> GetNewDataSourceView()
		{
			return new ViewXuLyQuyDoiDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewXuLyQuyDoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewXuLyQuyDoiDataSourceView : ReadOnlyDataSourceView<ViewXuLyQuyDoi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewXuLyQuyDoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewXuLyQuyDoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewXuLyQuyDoiDataSourceView(ViewXuLyQuyDoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewXuLyQuyDoiDataSource ViewXuLyQuyDoiOwner
		{
			get { return Owner as ViewXuLyQuyDoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewXuLyQuyDoiSelectMethod SelectMethod
		{
			get { return ViewXuLyQuyDoiOwner.SelectMethod; }
			set { ViewXuLyQuyDoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewXuLyQuyDoiService ViewXuLyQuyDoiProvider
		{
			get { return Provider as ViewXuLyQuyDoiService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewXuLyQuyDoi> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewXuLyQuyDoi> results = null;
			// ViewXuLyQuyDoi item;
			count = 0;
			
			System.Int32 sp1139_MaKetQua;

			switch ( SelectMethod )
			{
				case ViewXuLyQuyDoiSelectMethod.Get:
					results = ViewXuLyQuyDoiProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewXuLyQuyDoiSelectMethod.GetPaged:
					results = ViewXuLyQuyDoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewXuLyQuyDoiSelectMethod.GetAll:
					results = ViewXuLyQuyDoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewXuLyQuyDoiSelectMethod.Find:
					results = ViewXuLyQuyDoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewXuLyQuyDoiSelectMethod.GetByMaKetQua:
					sp1139_MaKetQua = (System.Int32) EntityUtil.ChangeType(values["MaKetQua"], typeof(System.Int32));
					results = ViewXuLyQuyDoiProvider.GetByMaKetQua(sp1139_MaKetQua, StartIndex, PageSize);
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

	#region ViewXuLyQuyDoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewXuLyQuyDoiDataSource.SelectMethod property.
	/// </summary>
	public enum ViewXuLyQuyDoiSelectMethod
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
		/// Represents the GetByMaKetQua method.
		/// </summary>
		GetByMaKetQua
	}
	
	#endregion ViewXuLyQuyDoiSelectMethod
	
	#region ViewXuLyQuyDoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewXuLyQuyDoiDataSource class.
	/// </summary>
	public class ViewXuLyQuyDoiDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewXuLyQuyDoi>
	{
		/// <summary>
		/// Initializes a new instance of the ViewXuLyQuyDoiDataSourceDesigner class.
		/// </summary>
		public ViewXuLyQuyDoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewXuLyQuyDoiSelectMethod SelectMethod
		{
			get { return ((ViewXuLyQuyDoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewXuLyQuyDoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewXuLyQuyDoiDataSourceActionList

	/// <summary>
	/// Supports the ViewXuLyQuyDoiDataSourceDesigner class.
	/// </summary>
	internal class ViewXuLyQuyDoiDataSourceActionList : DesignerActionList
	{
		private ViewXuLyQuyDoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewXuLyQuyDoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewXuLyQuyDoiDataSourceActionList(ViewXuLyQuyDoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewXuLyQuyDoiSelectMethod SelectMethod
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

	#endregion ViewXuLyQuyDoiDataSourceActionList

	#endregion ViewXuLyQuyDoiDataSourceDesigner

	#region ViewXuLyQuyDoiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewXuLyQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewXuLyQuyDoiFilter : SqlFilter<ViewXuLyQuyDoiColumn>
	{
	}

	#endregion ViewXuLyQuyDoiFilter

	#region ViewXuLyQuyDoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewXuLyQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewXuLyQuyDoiExpressionBuilder : SqlExpressionBuilder<ViewXuLyQuyDoiColumn>
	{
	}
	
	#endregion ViewXuLyQuyDoiExpressionBuilder		
}

