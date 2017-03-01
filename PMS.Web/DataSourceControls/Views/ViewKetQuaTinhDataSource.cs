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
	/// Represents the DataRepository.ViewKetQuaTinhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKetQuaTinhDataSourceDesigner))]
	public class ViewKetQuaTinhDataSource : ReadOnlyDataSource<ViewKetQuaTinh>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaTinhDataSource class.
		/// </summary>
		public ViewKetQuaTinhDataSource() : base(new ViewKetQuaTinhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKetQuaTinhDataSourceView used by the ViewKetQuaTinhDataSource.
		/// </summary>
		protected ViewKetQuaTinhDataSourceView ViewKetQuaTinhView
		{
			get { return ( View as ViewKetQuaTinhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKetQuaTinhDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKetQuaTinhSelectMethod SelectMethod
		{
			get
			{
				ViewKetQuaTinhSelectMethod selectMethod = ViewKetQuaTinhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKetQuaTinhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKetQuaTinhDataSourceView class that is to be
		/// used by the ViewKetQuaTinhDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKetQuaTinhDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKetQuaTinh, Object> GetNewDataSourceView()
		{
			return new ViewKetQuaTinhDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKetQuaTinhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKetQuaTinhDataSourceView : ReadOnlyDataSourceView<ViewKetQuaTinh>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaTinhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKetQuaTinhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKetQuaTinhDataSourceView(ViewKetQuaTinhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKetQuaTinhDataSource ViewKetQuaTinhOwner
		{
			get { return Owner as ViewKetQuaTinhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKetQuaTinhSelectMethod SelectMethod
		{
			get { return ViewKetQuaTinhOwner.SelectMethod; }
			set { ViewKetQuaTinhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKetQuaTinhService ViewKetQuaTinhProvider
		{
			get { return Provider as ViewKetQuaTinhService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKetQuaTinh> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKetQuaTinh> results = null;
			// ViewKetQuaTinh item;
			count = 0;
			
			System.String sp1006_NamHoc;
			System.String sp1006_HocKy;
			System.String sp1007_NamHoc;
			System.String sp1007_HocKy;
			System.Int32 sp1007_MaGiangVien;

			switch ( SelectMethod )
			{
				case ViewKetQuaTinhSelectMethod.Get:
					results = ViewKetQuaTinhProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKetQuaTinhSelectMethod.GetPaged:
					results = ViewKetQuaTinhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKetQuaTinhSelectMethod.GetAll:
					results = ViewKetQuaTinhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKetQuaTinhSelectMethod.Find:
					results = ViewKetQuaTinhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKetQuaTinhSelectMethod.GetByNamHocHocKy:
					sp1006_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1006_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewKetQuaTinhProvider.GetByNamHocHocKy(sp1006_NamHoc, sp1006_HocKy, StartIndex, PageSize);
					break;
				case ViewKetQuaTinhSelectMethod.GetByNamHocHocKyMaGiangVien:
					sp1007_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1007_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp1007_MaGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32));
					results = ViewKetQuaTinhProvider.GetByNamHocHocKyMaGiangVien(sp1007_NamHoc, sp1007_HocKy, sp1007_MaGiangVien, StartIndex, PageSize);
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

	#region ViewKetQuaTinhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKetQuaTinhDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKetQuaTinhSelectMethod
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
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHocHocKyMaGiangVien method.
		/// </summary>
		GetByNamHocHocKyMaGiangVien
	}
	
	#endregion ViewKetQuaTinhSelectMethod
	
	#region ViewKetQuaTinhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKetQuaTinhDataSource class.
	/// </summary>
	public class ViewKetQuaTinhDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKetQuaTinh>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKetQuaTinhDataSourceDesigner class.
		/// </summary>
		public ViewKetQuaTinhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKetQuaTinhSelectMethod SelectMethod
		{
			get { return ((ViewKetQuaTinhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKetQuaTinhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKetQuaTinhDataSourceActionList

	/// <summary>
	/// Supports the ViewKetQuaTinhDataSourceDesigner class.
	/// </summary>
	internal class ViewKetQuaTinhDataSourceActionList : DesignerActionList
	{
		private ViewKetQuaTinhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaTinhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKetQuaTinhDataSourceActionList(ViewKetQuaTinhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKetQuaTinhSelectMethod SelectMethod
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

	#endregion ViewKetQuaTinhDataSourceActionList

	#endregion ViewKetQuaTinhDataSourceDesigner

	#region ViewKetQuaTinhFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKetQuaTinhFilter : SqlFilter<ViewKetQuaTinhColumn>
	{
	}

	#endregion ViewKetQuaTinhFilter

	#region ViewKetQuaTinhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKetQuaTinhExpressionBuilder : SqlExpressionBuilder<ViewKetQuaTinhColumn>
	{
	}
	
	#endregion ViewKetQuaTinhExpressionBuilder		
}

