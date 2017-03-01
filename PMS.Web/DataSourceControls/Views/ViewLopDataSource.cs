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
	/// Represents the DataRepository.ViewLopProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewLopDataSourceDesigner))]
	public class ViewLopDataSource : ReadOnlyDataSource<ViewLop>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopDataSource class.
		/// </summary>
		public ViewLopDataSource() : base(new ViewLopService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewLopDataSourceView used by the ViewLopDataSource.
		/// </summary>
		protected ViewLopDataSourceView ViewLopView
		{
			get { return ( View as ViewLopDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewLopDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewLopSelectMethod SelectMethod
		{
			get
			{
				ViewLopSelectMethod selectMethod = ViewLopSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewLopSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewLopDataSourceView class that is to be
		/// used by the ViewLopDataSource.
		/// </summary>
		/// <returns>An instance of the ViewLopDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewLop, Object> GetNewDataSourceView()
		{
			return new ViewLopDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewLopDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewLopDataSourceView : ReadOnlyDataSourceView<ViewLop>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewLopDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewLopDataSourceView(ViewLopDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewLopDataSource ViewLopOwner
		{
			get { return Owner as ViewLopDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewLopSelectMethod SelectMethod
		{
			get { return ViewLopOwner.SelectMethod; }
			set { ViewLopOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewLopService ViewLopProvider
		{
			get { return Provider as ViewLopService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewLop> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewLop> results = null;
			// ViewLop item;
			count = 0;
			
			System.String sp1040_NhomQuyen;
			System.String sp1039_MaDonVi;

			switch ( SelectMethod )
			{
				case ViewLopSelectMethod.Get:
					results = ViewLopProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewLopSelectMethod.GetPaged:
					results = ViewLopProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewLopSelectMethod.GetAll:
					results = ViewLopProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewLopSelectMethod.Find:
					results = ViewLopProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewLopSelectMethod.GetByNhomQuyen:
					sp1040_NhomQuyen = (System.String) EntityUtil.ChangeType(values["NhomQuyen"], typeof(System.String));
					results = ViewLopProvider.GetByNhomQuyen(sp1040_NhomQuyen, StartIndex, PageSize);
					break;
				case ViewLopSelectMethod.GetByMaDonVi:
					sp1039_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewLopProvider.GetByMaDonVi(sp1039_MaDonVi, StartIndex, PageSize);
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

	#region ViewLopSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewLopDataSource.SelectMethod property.
	/// </summary>
	public enum ViewLopSelectMethod
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
		/// Represents the GetByNhomQuyen method.
		/// </summary>
		GetByNhomQuyen,
		/// <summary>
		/// Represents the GetByMaDonVi method.
		/// </summary>
		GetByMaDonVi
	}
	
	#endregion ViewLopSelectMethod
	
	#region ViewLopDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewLopDataSource class.
	/// </summary>
	public class ViewLopDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewLop>
	{
		/// <summary>
		/// Initializes a new instance of the ViewLopDataSourceDesigner class.
		/// </summary>
		public ViewLopDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewLopSelectMethod SelectMethod
		{
			get { return ((ViewLopDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewLopDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewLopDataSourceActionList

	/// <summary>
	/// Supports the ViewLopDataSourceDesigner class.
	/// </summary>
	internal class ViewLopDataSourceActionList : DesignerActionList
	{
		private ViewLopDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewLopDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewLopDataSourceActionList(ViewLopDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewLopSelectMethod SelectMethod
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

	#endregion ViewLopDataSourceActionList

	#endregion ViewLopDataSourceDesigner

	#region ViewLopFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopFilter : SqlFilter<ViewLopColumn>
	{
	}

	#endregion ViewLopFilter

	#region ViewLopExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopExpressionBuilder : SqlExpressionBuilder<ViewLopColumn>
	{
	}
	
	#endregion ViewLopExpressionBuilder		
}

