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
	/// Represents the DataRepository.ViewKhoaHocBacHeProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKhoaHocBacHeDataSourceDesigner))]
	public class ViewKhoaHocBacHeDataSource : ReadOnlyDataSource<ViewKhoaHocBacHe>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocBacHeDataSource class.
		/// </summary>
		public ViewKhoaHocBacHeDataSource() : base(new ViewKhoaHocBacHeService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKhoaHocBacHeDataSourceView used by the ViewKhoaHocBacHeDataSource.
		/// </summary>
		protected ViewKhoaHocBacHeDataSourceView ViewKhoaHocBacHeView
		{
			get { return ( View as ViewKhoaHocBacHeDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKhoaHocBacHeDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKhoaHocBacHeSelectMethod SelectMethod
		{
			get
			{
				ViewKhoaHocBacHeSelectMethod selectMethod = ViewKhoaHocBacHeSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKhoaHocBacHeSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKhoaHocBacHeDataSourceView class that is to be
		/// used by the ViewKhoaHocBacHeDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKhoaHocBacHeDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKhoaHocBacHe, Object> GetNewDataSourceView()
		{
			return new ViewKhoaHocBacHeDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKhoaHocBacHeDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKhoaHocBacHeDataSourceView : ReadOnlyDataSourceView<ViewKhoaHocBacHe>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocBacHeDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKhoaHocBacHeDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKhoaHocBacHeDataSourceView(ViewKhoaHocBacHeDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKhoaHocBacHeDataSource ViewKhoaHocBacHeOwner
		{
			get { return Owner as ViewKhoaHocBacHeDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKhoaHocBacHeSelectMethod SelectMethod
		{
			get { return ViewKhoaHocBacHeOwner.SelectMethod; }
			set { ViewKhoaHocBacHeOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKhoaHocBacHeService ViewKhoaHocBacHeProvider
		{
			get { return Provider as ViewKhoaHocBacHeService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKhoaHocBacHe> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKhoaHocBacHe> results = null;
			// ViewKhoaHocBacHe item;
			count = 0;
			
			System.String sp3110_MaBacDaoTao;
			System.String sp3111_MaHeDaoTao;
			System.String sp3111_MaBacDaoTao;

			switch ( SelectMethod )
			{
				case ViewKhoaHocBacHeSelectMethod.Get:
					results = ViewKhoaHocBacHeProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKhoaHocBacHeSelectMethod.GetPaged:
					results = ViewKhoaHocBacHeProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKhoaHocBacHeSelectMethod.GetAll:
					results = ViewKhoaHocBacHeProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKhoaHocBacHeSelectMethod.Find:
					results = ViewKhoaHocBacHeProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKhoaHocBacHeSelectMethod.GetByMaBacDaoTao:
					sp3110_MaBacDaoTao = (System.String) EntityUtil.ChangeType(values["MaBacDaoTao"], typeof(System.String));
					results = ViewKhoaHocBacHeProvider.GetByMaBacDaoTao(sp3110_MaBacDaoTao, StartIndex, PageSize);
					break;
				case ViewKhoaHocBacHeSelectMethod.GetByMaHeMaBac:
					sp3111_MaHeDaoTao = (System.String) EntityUtil.ChangeType(values["MaHeDaoTao"], typeof(System.String));
					sp3111_MaBacDaoTao = (System.String) EntityUtil.ChangeType(values["MaBacDaoTao"], typeof(System.String));
					results = ViewKhoaHocBacHeProvider.GetByMaHeMaBac(sp3111_MaHeDaoTao, sp3111_MaBacDaoTao, StartIndex, PageSize);
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

	#region ViewKhoaHocBacHeSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKhoaHocBacHeDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKhoaHocBacHeSelectMethod
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
		/// Represents the GetByMaBacDaoTao method.
		/// </summary>
		GetByMaBacDaoTao,
		/// <summary>
		/// Represents the GetByMaHeMaBac method.
		/// </summary>
		GetByMaHeMaBac
	}
	
	#endregion ViewKhoaHocBacHeSelectMethod
	
	#region ViewKhoaHocBacHeDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKhoaHocBacHeDataSource class.
	/// </summary>
	public class ViewKhoaHocBacHeDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKhoaHocBacHe>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocBacHeDataSourceDesigner class.
		/// </summary>
		public ViewKhoaHocBacHeDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKhoaHocBacHeSelectMethod SelectMethod
		{
			get { return ((ViewKhoaHocBacHeDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKhoaHocBacHeDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKhoaHocBacHeDataSourceActionList

	/// <summary>
	/// Supports the ViewKhoaHocBacHeDataSourceDesigner class.
	/// </summary>
	internal class ViewKhoaHocBacHeDataSourceActionList : DesignerActionList
	{
		private ViewKhoaHocBacHeDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocBacHeDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKhoaHocBacHeDataSourceActionList(ViewKhoaHocBacHeDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKhoaHocBacHeSelectMethod SelectMethod
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

	#endregion ViewKhoaHocBacHeDataSourceActionList

	#endregion ViewKhoaHocBacHeDataSourceDesigner

	#region ViewKhoaHocBacHeFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaHocBacHe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaHocBacHeFilter : SqlFilter<ViewKhoaHocBacHeColumn>
	{
	}

	#endregion ViewKhoaHocBacHeFilter

	#region ViewKhoaHocBacHeExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaHocBacHe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaHocBacHeExpressionBuilder : SqlExpressionBuilder<ViewKhoaHocBacHeColumn>
	{
	}
	
	#endregion ViewKhoaHocBacHeExpressionBuilder		
}

