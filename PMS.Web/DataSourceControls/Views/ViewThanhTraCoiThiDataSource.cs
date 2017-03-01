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
	/// Represents the DataRepository.ViewThanhTraCoiThiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThanhTraCoiThiDataSourceDesigner))]
	public class ViewThanhTraCoiThiDataSource : ReadOnlyDataSource<ViewThanhTraCoiThi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraCoiThiDataSource class.
		/// </summary>
		public ViewThanhTraCoiThiDataSource() : base(new ViewThanhTraCoiThiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThanhTraCoiThiDataSourceView used by the ViewThanhTraCoiThiDataSource.
		/// </summary>
		protected ViewThanhTraCoiThiDataSourceView ViewThanhTraCoiThiView
		{
			get { return ( View as ViewThanhTraCoiThiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThanhTraCoiThiDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThanhTraCoiThiSelectMethod SelectMethod
		{
			get
			{
				ViewThanhTraCoiThiSelectMethod selectMethod = ViewThanhTraCoiThiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThanhTraCoiThiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThanhTraCoiThiDataSourceView class that is to be
		/// used by the ViewThanhTraCoiThiDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThanhTraCoiThiDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThanhTraCoiThi, Object> GetNewDataSourceView()
		{
			return new ViewThanhTraCoiThiDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThanhTraCoiThiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThanhTraCoiThiDataSourceView : ReadOnlyDataSourceView<ViewThanhTraCoiThi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraCoiThiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThanhTraCoiThiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThanhTraCoiThiDataSourceView(ViewThanhTraCoiThiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThanhTraCoiThiDataSource ViewThanhTraCoiThiOwner
		{
			get { return Owner as ViewThanhTraCoiThiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThanhTraCoiThiSelectMethod SelectMethod
		{
			get { return ViewThanhTraCoiThiOwner.SelectMethod; }
			set { ViewThanhTraCoiThiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThanhTraCoiThiService ViewThanhTraCoiThiProvider
		{
			get { return Provider as ViewThanhTraCoiThiService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThanhTraCoiThi> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThanhTraCoiThi> results = null;
			// ViewThanhTraCoiThi item;
			count = 0;
			
			System.String sp1090_TuNgay;
			System.String sp1090_DenNgay;
			System.String sp1090_ToaNha;

			switch ( SelectMethod )
			{
				case ViewThanhTraCoiThiSelectMethod.Get:
					results = ViewThanhTraCoiThiProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThanhTraCoiThiSelectMethod.GetPaged:
					results = ViewThanhTraCoiThiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThanhTraCoiThiSelectMethod.GetAll:
					results = ViewThanhTraCoiThiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThanhTraCoiThiSelectMethod.Find:
					results = ViewThanhTraCoiThiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThanhTraCoiThiSelectMethod.GetByNgayCoSoToaNha:
					sp1090_TuNgay = (System.String) EntityUtil.ChangeType(values["TuNgay"], typeof(System.String));
					sp1090_DenNgay = (System.String) EntityUtil.ChangeType(values["DenNgay"], typeof(System.String));
					sp1090_ToaNha = (System.String) EntityUtil.ChangeType(values["ToaNha"], typeof(System.String));
					results = ViewThanhTraCoiThiProvider.GetByNgayCoSoToaNha(sp1090_TuNgay, sp1090_DenNgay, sp1090_ToaNha, StartIndex, PageSize);
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

	#region ViewThanhTraCoiThiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThanhTraCoiThiDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThanhTraCoiThiSelectMethod
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
		/// Represents the GetByNgayCoSoToaNha method.
		/// </summary>
		GetByNgayCoSoToaNha
	}
	
	#endregion ViewThanhTraCoiThiSelectMethod
	
	#region ViewThanhTraCoiThiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThanhTraCoiThiDataSource class.
	/// </summary>
	public class ViewThanhTraCoiThiDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThanhTraCoiThi>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThanhTraCoiThiDataSourceDesigner class.
		/// </summary>
		public ViewThanhTraCoiThiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThanhTraCoiThiSelectMethod SelectMethod
		{
			get { return ((ViewThanhTraCoiThiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThanhTraCoiThiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThanhTraCoiThiDataSourceActionList

	/// <summary>
	/// Supports the ViewThanhTraCoiThiDataSourceDesigner class.
	/// </summary>
	internal class ViewThanhTraCoiThiDataSourceActionList : DesignerActionList
	{
		private ViewThanhTraCoiThiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraCoiThiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThanhTraCoiThiDataSourceActionList(ViewThanhTraCoiThiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThanhTraCoiThiSelectMethod SelectMethod
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

	#endregion ViewThanhTraCoiThiDataSourceActionList

	#endregion ViewThanhTraCoiThiDataSourceDesigner

	#region ViewThanhTraCoiThiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraCoiThiFilter : SqlFilter<ViewThanhTraCoiThiColumn>
	{
	}

	#endregion ViewThanhTraCoiThiFilter

	#region ViewThanhTraCoiThiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraCoiThiExpressionBuilder : SqlExpressionBuilder<ViewThanhTraCoiThiColumn>
	{
	}
	
	#endregion ViewThanhTraCoiThiExpressionBuilder		
}

