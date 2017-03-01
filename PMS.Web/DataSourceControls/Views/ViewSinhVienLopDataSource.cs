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
	/// Represents the DataRepository.ViewSinhVienLopProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewSinhVienLopDataSourceDesigner))]
	public class ViewSinhVienLopDataSource : ReadOnlyDataSource<ViewSinhVienLop>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopDataSource class.
		/// </summary>
		public ViewSinhVienLopDataSource() : base(new ViewSinhVienLopService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewSinhVienLopDataSourceView used by the ViewSinhVienLopDataSource.
		/// </summary>
		protected ViewSinhVienLopDataSourceView ViewSinhVienLopView
		{
			get { return ( View as ViewSinhVienLopDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewSinhVienLopDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewSinhVienLopSelectMethod SelectMethod
		{
			get
			{
				ViewSinhVienLopSelectMethod selectMethod = ViewSinhVienLopSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewSinhVienLopSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewSinhVienLopDataSourceView class that is to be
		/// used by the ViewSinhVienLopDataSource.
		/// </summary>
		/// <returns>An instance of the ViewSinhVienLopDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewSinhVienLop, Object> GetNewDataSourceView()
		{
			return new ViewSinhVienLopDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewSinhVienLopDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewSinhVienLopDataSourceView : ReadOnlyDataSourceView<ViewSinhVienLop>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewSinhVienLopDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewSinhVienLopDataSourceView(ViewSinhVienLopDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewSinhVienLopDataSource ViewSinhVienLopOwner
		{
			get { return Owner as ViewSinhVienLopDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewSinhVienLopSelectMethod SelectMethod
		{
			get { return ViewSinhVienLopOwner.SelectMethod; }
			set { ViewSinhVienLopOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewSinhVienLopService ViewSinhVienLopProvider
		{
			get { return Provider as ViewSinhVienLopService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewSinhVienLop> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewSinhVienLop> results = null;
			// ViewSinhVienLop item;
			count = 0;
			
			System.String sp1080_MaKhoa;

			switch ( SelectMethod )
			{
				case ViewSinhVienLopSelectMethod.Get:
					results = ViewSinhVienLopProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewSinhVienLopSelectMethod.GetPaged:
					results = ViewSinhVienLopProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewSinhVienLopSelectMethod.GetAll:
					results = ViewSinhVienLopProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewSinhVienLopSelectMethod.Find:
					results = ViewSinhVienLopProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewSinhVienLopSelectMethod.GetByMaKhoa:
					sp1080_MaKhoa = (System.String) EntityUtil.ChangeType(values["MaKhoa"], typeof(System.String));
					results = ViewSinhVienLopProvider.GetByMaKhoa(sp1080_MaKhoa, StartIndex, PageSize);
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

	#region ViewSinhVienLopSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewSinhVienLopDataSource.SelectMethod property.
	/// </summary>
	public enum ViewSinhVienLopSelectMethod
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
		/// Represents the GetByMaKhoa method.
		/// </summary>
		GetByMaKhoa
	}
	
	#endregion ViewSinhVienLopSelectMethod
	
	#region ViewSinhVienLopDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewSinhVienLopDataSource class.
	/// </summary>
	public class ViewSinhVienLopDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewSinhVienLop>
	{
		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopDataSourceDesigner class.
		/// </summary>
		public ViewSinhVienLopDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewSinhVienLopSelectMethod SelectMethod
		{
			get { return ((ViewSinhVienLopDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewSinhVienLopDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewSinhVienLopDataSourceActionList

	/// <summary>
	/// Supports the ViewSinhVienLopDataSourceDesigner class.
	/// </summary>
	internal class ViewSinhVienLopDataSourceActionList : DesignerActionList
	{
		private ViewSinhVienLopDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewSinhVienLopDataSourceActionList(ViewSinhVienLopDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewSinhVienLopSelectMethod SelectMethod
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

	#endregion ViewSinhVienLopDataSourceActionList

	#endregion ViewSinhVienLopDataSourceDesigner

	#region ViewSinhVienLopFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienLop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienLopFilter : SqlFilter<ViewSinhVienLopColumn>
	{
	}

	#endregion ViewSinhVienLopFilter

	#region ViewSinhVienLopExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienLop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienLopExpressionBuilder : SqlExpressionBuilder<ViewSinhVienLopColumn>
	{
	}
	
	#endregion ViewSinhVienLopExpressionBuilder		
}

