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
	/// Represents the DataRepository.ViewQuyetDinhDoiHocHamHocViProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewQuyetDinhDoiHocHamHocViDataSourceDesigner))]
	public class ViewQuyetDinhDoiHocHamHocViDataSource : ReadOnlyDataSource<ViewQuyetDinhDoiHocHamHocVi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViDataSource class.
		/// </summary>
		public ViewQuyetDinhDoiHocHamHocViDataSource() : base(new ViewQuyetDinhDoiHocHamHocViService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewQuyetDinhDoiHocHamHocViDataSourceView used by the ViewQuyetDinhDoiHocHamHocViDataSource.
		/// </summary>
		protected ViewQuyetDinhDoiHocHamHocViDataSourceView ViewQuyetDinhDoiHocHamHocViView
		{
			get { return ( View as ViewQuyetDinhDoiHocHamHocViDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewQuyetDinhDoiHocHamHocViDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewQuyetDinhDoiHocHamHocViSelectMethod SelectMethod
		{
			get
			{
				ViewQuyetDinhDoiHocHamHocViSelectMethod selectMethod = ViewQuyetDinhDoiHocHamHocViSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewQuyetDinhDoiHocHamHocViSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewQuyetDinhDoiHocHamHocViDataSourceView class that is to be
		/// used by the ViewQuyetDinhDoiHocHamHocViDataSource.
		/// </summary>
		/// <returns>An instance of the ViewQuyetDinhDoiHocHamHocViDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewQuyetDinhDoiHocHamHocVi, Object> GetNewDataSourceView()
		{
			return new ViewQuyetDinhDoiHocHamHocViDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewQuyetDinhDoiHocHamHocViDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewQuyetDinhDoiHocHamHocViDataSourceView : ReadOnlyDataSourceView<ViewQuyetDinhDoiHocHamHocVi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewQuyetDinhDoiHocHamHocViDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewQuyetDinhDoiHocHamHocViDataSourceView(ViewQuyetDinhDoiHocHamHocViDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewQuyetDinhDoiHocHamHocViDataSource ViewQuyetDinhDoiHocHamHocViOwner
		{
			get { return Owner as ViewQuyetDinhDoiHocHamHocViDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewQuyetDinhDoiHocHamHocViSelectMethod SelectMethod
		{
			get { return ViewQuyetDinhDoiHocHamHocViOwner.SelectMethod; }
			set { ViewQuyetDinhDoiHocHamHocViOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewQuyetDinhDoiHocHamHocViService ViewQuyetDinhDoiHocHamHocViProvider
		{
			get { return Provider as ViewQuyetDinhDoiHocHamHocViService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewQuyetDinhDoiHocHamHocVi> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewQuyetDinhDoiHocHamHocVi> results = null;
			// ViewQuyetDinhDoiHocHamHocVi item;
			count = 0;
			
			System.Int32 sp3174_MaGiangVien;

			switch ( SelectMethod )
			{
				case ViewQuyetDinhDoiHocHamHocViSelectMethod.Get:
					results = ViewQuyetDinhDoiHocHamHocViProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewQuyetDinhDoiHocHamHocViSelectMethod.GetPaged:
					results = ViewQuyetDinhDoiHocHamHocViProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewQuyetDinhDoiHocHamHocViSelectMethod.GetAll:
					results = ViewQuyetDinhDoiHocHamHocViProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewQuyetDinhDoiHocHamHocViSelectMethod.Find:
					results = ViewQuyetDinhDoiHocHamHocViProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewQuyetDinhDoiHocHamHocViSelectMethod.GetByMaGiangVien:
					sp3174_MaGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32));
					results = ViewQuyetDinhDoiHocHamHocViProvider.GetByMaGiangVien(sp3174_MaGiangVien, StartIndex, PageSize);
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

	#region ViewQuyetDinhDoiHocHamHocViSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewQuyetDinhDoiHocHamHocViDataSource.SelectMethod property.
	/// </summary>
	public enum ViewQuyetDinhDoiHocHamHocViSelectMethod
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
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion ViewQuyetDinhDoiHocHamHocViSelectMethod
	
	#region ViewQuyetDinhDoiHocHamHocViDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewQuyetDinhDoiHocHamHocViDataSource class.
	/// </summary>
	public class ViewQuyetDinhDoiHocHamHocViDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewQuyetDinhDoiHocHamHocVi>
	{
		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViDataSourceDesigner class.
		/// </summary>
		public ViewQuyetDinhDoiHocHamHocViDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewQuyetDinhDoiHocHamHocViSelectMethod SelectMethod
		{
			get { return ((ViewQuyetDinhDoiHocHamHocViDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewQuyetDinhDoiHocHamHocViDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewQuyetDinhDoiHocHamHocViDataSourceActionList

	/// <summary>
	/// Supports the ViewQuyetDinhDoiHocHamHocViDataSourceDesigner class.
	/// </summary>
	internal class ViewQuyetDinhDoiHocHamHocViDataSourceActionList : DesignerActionList
	{
		private ViewQuyetDinhDoiHocHamHocViDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewQuyetDinhDoiHocHamHocViDataSourceActionList(ViewQuyetDinhDoiHocHamHocViDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewQuyetDinhDoiHocHamHocViSelectMethod SelectMethod
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

	#endregion ViewQuyetDinhDoiHocHamHocViDataSourceActionList

	#endregion ViewQuyetDinhDoiHocHamHocViDataSourceDesigner

	#region ViewQuyetDinhDoiHocHamHocViFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewQuyetDinhDoiHocHamHocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewQuyetDinhDoiHocHamHocViFilter : SqlFilter<ViewQuyetDinhDoiHocHamHocViColumn>
	{
	}

	#endregion ViewQuyetDinhDoiHocHamHocViFilter

	#region ViewQuyetDinhDoiHocHamHocViExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewQuyetDinhDoiHocHamHocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewQuyetDinhDoiHocHamHocViExpressionBuilder : SqlExpressionBuilder<ViewQuyetDinhDoiHocHamHocViColumn>
	{
	}
	
	#endregion ViewQuyetDinhDoiHocHamHocViExpressionBuilder		
}

