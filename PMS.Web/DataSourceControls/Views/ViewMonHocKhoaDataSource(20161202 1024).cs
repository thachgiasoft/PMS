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
	/// Represents the DataRepository.ViewMonHocKhoaProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewMonHocKhoaDataSourceDesigner))]
	public class ViewMonHocKhoaDataSource : ReadOnlyDataSource<ViewMonHocKhoa>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonHocKhoaDataSource class.
		/// </summary>
		public ViewMonHocKhoaDataSource() : base(new ViewMonHocKhoaService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewMonHocKhoaDataSourceView used by the ViewMonHocKhoaDataSource.
		/// </summary>
		protected ViewMonHocKhoaDataSourceView ViewMonHocKhoaView
		{
			get { return ( View as ViewMonHocKhoaDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewMonHocKhoaDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewMonHocKhoaSelectMethod SelectMethod
		{
			get
			{
				ViewMonHocKhoaSelectMethod selectMethod = ViewMonHocKhoaSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewMonHocKhoaSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewMonHocKhoaDataSourceView class that is to be
		/// used by the ViewMonHocKhoaDataSource.
		/// </summary>
		/// <returns>An instance of the ViewMonHocKhoaDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewMonHocKhoa, Object> GetNewDataSourceView()
		{
			return new ViewMonHocKhoaDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewMonHocKhoaDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewMonHocKhoaDataSourceView : ReadOnlyDataSourceView<ViewMonHocKhoa>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonHocKhoaDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewMonHocKhoaDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewMonHocKhoaDataSourceView(ViewMonHocKhoaDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewMonHocKhoaDataSource ViewMonHocKhoaOwner
		{
			get { return Owner as ViewMonHocKhoaDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewMonHocKhoaSelectMethod SelectMethod
		{
			get { return ViewMonHocKhoaOwner.SelectMethod; }
			set { ViewMonHocKhoaOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewMonHocKhoaService ViewMonHocKhoaProvider
		{
			get { return Provider as ViewMonHocKhoaService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewMonHocKhoa> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewMonHocKhoa> results = null;
			// ViewMonHocKhoa item;
			count = 0;
			
			System.String sp3155_MaDonVi;

			switch ( SelectMethod )
			{
				case ViewMonHocKhoaSelectMethod.Get:
					results = ViewMonHocKhoaProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewMonHocKhoaSelectMethod.GetPaged:
					results = ViewMonHocKhoaProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewMonHocKhoaSelectMethod.GetAll:
					results = ViewMonHocKhoaProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewMonHocKhoaSelectMethod.Find:
					results = ViewMonHocKhoaProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewMonHocKhoaSelectMethod.GetByMaDonVi:
					sp3155_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewMonHocKhoaProvider.GetByMaDonVi(sp3155_MaDonVi, StartIndex, PageSize);
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

	#region ViewMonHocKhoaSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewMonHocKhoaDataSource.SelectMethod property.
	/// </summary>
	public enum ViewMonHocKhoaSelectMethod
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
		/// Represents the GetByMaDonVi method.
		/// </summary>
		GetByMaDonVi
	}
	
	#endregion ViewMonHocKhoaSelectMethod
	
	#region ViewMonHocKhoaDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewMonHocKhoaDataSource class.
	/// </summary>
	public class ViewMonHocKhoaDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewMonHocKhoa>
	{
		/// <summary>
		/// Initializes a new instance of the ViewMonHocKhoaDataSourceDesigner class.
		/// </summary>
		public ViewMonHocKhoaDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewMonHocKhoaSelectMethod SelectMethod
		{
			get { return ((ViewMonHocKhoaDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewMonHocKhoaDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewMonHocKhoaDataSourceActionList

	/// <summary>
	/// Supports the ViewMonHocKhoaDataSourceDesigner class.
	/// </summary>
	internal class ViewMonHocKhoaDataSourceActionList : DesignerActionList
	{
		private ViewMonHocKhoaDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewMonHocKhoaDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewMonHocKhoaDataSourceActionList(ViewMonHocKhoaDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewMonHocKhoaSelectMethod SelectMethod
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

	#endregion ViewMonHocKhoaDataSourceActionList

	#endregion ViewMonHocKhoaDataSourceDesigner

	#region ViewMonHocKhoaFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonHocKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonHocKhoaFilter : SqlFilter<ViewMonHocKhoaColumn>
	{
	}

	#endregion ViewMonHocKhoaFilter

	#region ViewMonHocKhoaExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonHocKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonHocKhoaExpressionBuilder : SqlExpressionBuilder<ViewMonHocKhoaColumn>
	{
	}
	
	#endregion ViewMonHocKhoaExpressionBuilder		
}

