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
	/// Represents the DataRepository.ViewSinhVienLopHocPhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewSinhVienLopHocPhanDataSourceDesigner))]
	public class ViewSinhVienLopHocPhanDataSource : ReadOnlyDataSource<ViewSinhVienLopHocPhan>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanDataSource class.
		/// </summary>
		public ViewSinhVienLopHocPhanDataSource() : base(new ViewSinhVienLopHocPhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewSinhVienLopHocPhanDataSourceView used by the ViewSinhVienLopHocPhanDataSource.
		/// </summary>
		protected ViewSinhVienLopHocPhanDataSourceView ViewSinhVienLopHocPhanView
		{
			get { return ( View as ViewSinhVienLopHocPhanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewSinhVienLopHocPhanDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewSinhVienLopHocPhanSelectMethod SelectMethod
		{
			get
			{
				ViewSinhVienLopHocPhanSelectMethod selectMethod = ViewSinhVienLopHocPhanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewSinhVienLopHocPhanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewSinhVienLopHocPhanDataSourceView class that is to be
		/// used by the ViewSinhVienLopHocPhanDataSource.
		/// </summary>
		/// <returns>An instance of the ViewSinhVienLopHocPhanDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewSinhVienLopHocPhan, Object> GetNewDataSourceView()
		{
			return new ViewSinhVienLopHocPhanDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewSinhVienLopHocPhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewSinhVienLopHocPhanDataSourceView : ReadOnlyDataSourceView<ViewSinhVienLopHocPhan>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewSinhVienLopHocPhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewSinhVienLopHocPhanDataSourceView(ViewSinhVienLopHocPhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewSinhVienLopHocPhanDataSource ViewSinhVienLopHocPhanOwner
		{
			get { return Owner as ViewSinhVienLopHocPhanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewSinhVienLopHocPhanSelectMethod SelectMethod
		{
			get { return ViewSinhVienLopHocPhanOwner.SelectMethod; }
			set { ViewSinhVienLopHocPhanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewSinhVienLopHocPhanService ViewSinhVienLopHocPhanProvider
		{
			get { return Provider as ViewSinhVienLopHocPhanService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewSinhVienLopHocPhan> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewSinhVienLopHocPhan> results = null;
			// ViewSinhVienLopHocPhan item;
			count = 0;
			
			System.String sp1081_MaLopHocPhan;

			switch ( SelectMethod )
			{
				case ViewSinhVienLopHocPhanSelectMethod.Get:
					results = ViewSinhVienLopHocPhanProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewSinhVienLopHocPhanSelectMethod.GetPaged:
					results = ViewSinhVienLopHocPhanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewSinhVienLopHocPhanSelectMethod.GetAll:
					results = ViewSinhVienLopHocPhanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewSinhVienLopHocPhanSelectMethod.Find:
					results = ViewSinhVienLopHocPhanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewSinhVienLopHocPhanSelectMethod.GetByMaLopHocPhan:
					sp1081_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					results = ViewSinhVienLopHocPhanProvider.GetByMaLopHocPhan(sp1081_MaLopHocPhan, StartIndex, PageSize);
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

	#region ViewSinhVienLopHocPhanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewSinhVienLopHocPhanDataSource.SelectMethod property.
	/// </summary>
	public enum ViewSinhVienLopHocPhanSelectMethod
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
		/// Represents the GetByMaLopHocPhan method.
		/// </summary>
		GetByMaLopHocPhan
	}
	
	#endregion ViewSinhVienLopHocPhanSelectMethod
	
	#region ViewSinhVienLopHocPhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewSinhVienLopHocPhanDataSource class.
	/// </summary>
	public class ViewSinhVienLopHocPhanDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewSinhVienLopHocPhan>
	{
		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanDataSourceDesigner class.
		/// </summary>
		public ViewSinhVienLopHocPhanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewSinhVienLopHocPhanSelectMethod SelectMethod
		{
			get { return ((ViewSinhVienLopHocPhanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewSinhVienLopHocPhanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewSinhVienLopHocPhanDataSourceActionList

	/// <summary>
	/// Supports the ViewSinhVienLopHocPhanDataSourceDesigner class.
	/// </summary>
	internal class ViewSinhVienLopHocPhanDataSourceActionList : DesignerActionList
	{
		private ViewSinhVienLopHocPhanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewSinhVienLopHocPhanDataSourceActionList(ViewSinhVienLopHocPhanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewSinhVienLopHocPhanSelectMethod SelectMethod
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

	#endregion ViewSinhVienLopHocPhanDataSourceActionList

	#endregion ViewSinhVienLopHocPhanDataSourceDesigner

	#region ViewSinhVienLopHocPhanFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienLopHocPhanFilter : SqlFilter<ViewSinhVienLopHocPhanColumn>
	{
	}

	#endregion ViewSinhVienLopHocPhanFilter

	#region ViewSinhVienLopHocPhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienLopHocPhanExpressionBuilder : SqlExpressionBuilder<ViewSinhVienLopHocPhanColumn>
	{
	}
	
	#endregion ViewSinhVienLopHocPhanExpressionBuilder		
}

