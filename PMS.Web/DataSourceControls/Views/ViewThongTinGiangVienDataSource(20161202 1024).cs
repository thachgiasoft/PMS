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
	/// Represents the DataRepository.ViewThongTinGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThongTinGiangVienDataSourceDesigner))]
	public class ViewThongTinGiangVienDataSource : ReadOnlyDataSource<ViewThongTinGiangVien>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangVienDataSource class.
		/// </summary>
		public ViewThongTinGiangVienDataSource() : base(new ViewThongTinGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThongTinGiangVienDataSourceView used by the ViewThongTinGiangVienDataSource.
		/// </summary>
		protected ViewThongTinGiangVienDataSourceView ViewThongTinGiangVienView
		{
			get { return ( View as ViewThongTinGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThongTinGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThongTinGiangVienSelectMethod SelectMethod
		{
			get
			{
				ViewThongTinGiangVienSelectMethod selectMethod = ViewThongTinGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThongTinGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThongTinGiangVienDataSourceView class that is to be
		/// used by the ViewThongTinGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThongTinGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThongTinGiangVien, Object> GetNewDataSourceView()
		{
			return new ViewThongTinGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThongTinGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThongTinGiangVienDataSourceView : ReadOnlyDataSourceView<ViewThongTinGiangVien>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThongTinGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThongTinGiangVienDataSourceView(ViewThongTinGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThongTinGiangVienDataSource ViewThongTinGiangVienOwner
		{
			get { return Owner as ViewThongTinGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThongTinGiangVienSelectMethod SelectMethod
		{
			get { return ViewThongTinGiangVienOwner.SelectMethod; }
			set { ViewThongTinGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThongTinGiangVienService ViewThongTinGiangVienProvider
		{
			get { return Provider as ViewThongTinGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThongTinGiangVien> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThongTinGiangVien> results = null;
			// ViewThongTinGiangVien item;
			count = 0;
			
			System.String sp3212_MaQuanLy;
			System.String sp3213_MaQuanLy;

			switch ( SelectMethod )
			{
				case ViewThongTinGiangVienSelectMethod.Get:
					results = ViewThongTinGiangVienProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThongTinGiangVienSelectMethod.GetPaged:
					results = ViewThongTinGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThongTinGiangVienSelectMethod.GetAll:
					results = ViewThongTinGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThongTinGiangVienSelectMethod.Find:
					results = ViewThongTinGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThongTinGiangVienSelectMethod.GetByMaGiangVien:
					sp3212_MaQuanLy = (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String));
					results = ViewThongTinGiangVienProvider.GetByMaGiangVien(sp3212_MaQuanLy, StartIndex, PageSize);
					break;
				case ViewThongTinGiangVienSelectMethod.GetByMaQuanLy:
					sp3213_MaQuanLy = (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String));
					results = ViewThongTinGiangVienProvider.GetByMaQuanLy(sp3213_MaQuanLy, StartIndex, PageSize);
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

	#region ViewThongTinGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThongTinGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThongTinGiangVienSelectMethod
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
		GetByMaGiangVien,
		/// <summary>
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy
	}
	
	#endregion ViewThongTinGiangVienSelectMethod
	
	#region ViewThongTinGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThongTinGiangVienDataSource class.
	/// </summary>
	public class ViewThongTinGiangVienDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThongTinGiangVien>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangVienDataSourceDesigner class.
		/// </summary>
		public ViewThongTinGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThongTinGiangVienSelectMethod SelectMethod
		{
			get { return ((ViewThongTinGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThongTinGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThongTinGiangVienDataSourceActionList

	/// <summary>
	/// Supports the ViewThongTinGiangVienDataSourceDesigner class.
	/// </summary>
	internal class ViewThongTinGiangVienDataSourceActionList : DesignerActionList
	{
		private ViewThongTinGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThongTinGiangVienDataSourceActionList(ViewThongTinGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThongTinGiangVienSelectMethod SelectMethod
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

	#endregion ViewThongTinGiangVienDataSourceActionList

	#endregion ViewThongTinGiangVienDataSourceDesigner

	#region ViewThongTinGiangVienFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinGiangVienFilter : SqlFilter<ViewThongTinGiangVienColumn>
	{
	}

	#endregion ViewThongTinGiangVienFilter

	#region ViewThongTinGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinGiangVienExpressionBuilder : SqlExpressionBuilder<ViewThongTinGiangVienColumn>
	{
	}
	
	#endregion ViewThongTinGiangVienExpressionBuilder		
}

