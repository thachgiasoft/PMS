#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.ThucGiangMonThucTeTuHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThucGiangMonThucTeTuHocDataSourceDesigner))]
	public class ThucGiangMonThucTeTuHocDataSource : ProviderDataSource<ThucGiangMonThucTeTuHoc, ThucGiangMonThucTeTuHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThucGiangMonThucTeTuHocDataSource class.
		/// </summary>
		public ThucGiangMonThucTeTuHocDataSource() : base(new ThucGiangMonThucTeTuHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThucGiangMonThucTeTuHocDataSourceView used by the ThucGiangMonThucTeTuHocDataSource.
		/// </summary>
		protected ThucGiangMonThucTeTuHocDataSourceView ThucGiangMonThucTeTuHocView
		{
			get { return ( View as ThucGiangMonThucTeTuHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThucGiangMonThucTeTuHocDataSource control invokes to retrieve data.
		/// </summary>
		public ThucGiangMonThucTeTuHocSelectMethod SelectMethod
		{
			get
			{
				ThucGiangMonThucTeTuHocSelectMethod selectMethod = ThucGiangMonThucTeTuHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThucGiangMonThucTeTuHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThucGiangMonThucTeTuHocDataSourceView class that is to be
		/// used by the ThucGiangMonThucTeTuHocDataSource.
		/// </summary>
		/// <returns>An instance of the ThucGiangMonThucTeTuHocDataSourceView class.</returns>
		protected override BaseDataSourceView<ThucGiangMonThucTeTuHoc, ThucGiangMonThucTeTuHocKey> GetNewDataSourceView()
		{
			return new ThucGiangMonThucTeTuHocDataSourceView(this, DefaultViewName);
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
	/// Supports the ThucGiangMonThucTeTuHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThucGiangMonThucTeTuHocDataSourceView : ProviderDataSourceView<ThucGiangMonThucTeTuHoc, ThucGiangMonThucTeTuHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThucGiangMonThucTeTuHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThucGiangMonThucTeTuHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThucGiangMonThucTeTuHocDataSourceView(ThucGiangMonThucTeTuHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThucGiangMonThucTeTuHocDataSource ThucGiangMonThucTeTuHocOwner
		{
			get { return Owner as ThucGiangMonThucTeTuHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThucGiangMonThucTeTuHocSelectMethod SelectMethod
		{
			get { return ThucGiangMonThucTeTuHocOwner.SelectMethod; }
			set { ThucGiangMonThucTeTuHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThucGiangMonThucTeTuHocService ThucGiangMonThucTeTuHocProvider
		{
			get { return Provider as ThucGiangMonThucTeTuHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThucGiangMonThucTeTuHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThucGiangMonThucTeTuHoc> results = null;
			ThucGiangMonThucTeTuHoc item;
			count = 0;
			
			System.Int32 _maQuanLy;
			System.Int32? _maHeSoCongViec_nullable;

			switch ( SelectMethod )
			{
				case ThucGiangMonThucTeTuHocSelectMethod.Get:
					ThucGiangMonThucTeTuHocKey entityKey  = new ThucGiangMonThucTeTuHocKey();
					entityKey.Load(values);
					item = ThucGiangMonThucTeTuHocProvider.Get(entityKey);
					results = new TList<ThucGiangMonThucTeTuHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThucGiangMonThucTeTuHocSelectMethod.GetAll:
                    results = ThucGiangMonThucTeTuHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThucGiangMonThucTeTuHocSelectMethod.GetPaged:
					results = ThucGiangMonThucTeTuHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThucGiangMonThucTeTuHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThucGiangMonThucTeTuHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThucGiangMonThucTeTuHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThucGiangMonThucTeTuHocSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.Int32)) : (int)0;
					item = ThucGiangMonThucTeTuHocProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<ThucGiangMonThucTeTuHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case ThucGiangMonThucTeTuHocSelectMethod.GetByMaHeSoCongViec:
					_maHeSoCongViec_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaHeSoCongViec"], typeof(System.Int32?));
					results = ThucGiangMonThucTeTuHocProvider.GetByMaHeSoCongViec(_maHeSoCongViec_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
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
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == ThucGiangMonThucTeTuHocSelectMethod.Get || SelectMethod == ThucGiangMonThucTeTuHocSelectMethod.GetByMaQuanLy )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				ThucGiangMonThucTeTuHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThucGiangMonThucTeTuHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<ThucGiangMonThucTeTuHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThucGiangMonThucTeTuHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThucGiangMonThucTeTuHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThucGiangMonThucTeTuHocDataSource class.
	/// </summary>
	public class ThucGiangMonThucTeTuHocDataSourceDesigner : ProviderDataSourceDesigner<ThucGiangMonThucTeTuHoc, ThucGiangMonThucTeTuHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThucGiangMonThucTeTuHocDataSourceDesigner class.
		/// </summary>
		public ThucGiangMonThucTeTuHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThucGiangMonThucTeTuHocSelectMethod SelectMethod
		{
			get { return ((ThucGiangMonThucTeTuHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThucGiangMonThucTeTuHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThucGiangMonThucTeTuHocDataSourceActionList

	/// <summary>
	/// Supports the ThucGiangMonThucTeTuHocDataSourceDesigner class.
	/// </summary>
	internal class ThucGiangMonThucTeTuHocDataSourceActionList : DesignerActionList
	{
		private ThucGiangMonThucTeTuHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThucGiangMonThucTeTuHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThucGiangMonThucTeTuHocDataSourceActionList(ThucGiangMonThucTeTuHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThucGiangMonThucTeTuHocSelectMethod SelectMethod
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

	#endregion ThucGiangMonThucTeTuHocDataSourceActionList
	
	#endregion ThucGiangMonThucTeTuHocDataSourceDesigner
	
	#region ThucGiangMonThucTeTuHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThucGiangMonThucTeTuHocDataSource.SelectMethod property.
	/// </summary>
	public enum ThucGiangMonThucTeTuHocSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy,
		/// <summary>
		/// Represents the GetByMaHeSoCongViec method.
		/// </summary>
		GetByMaHeSoCongViec
	}
	
	#endregion ThucGiangMonThucTeTuHocSelectMethod

	#region ThucGiangMonThucTeTuHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThucGiangMonThucTeTuHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThucGiangMonThucTeTuHocFilter : SqlFilter<ThucGiangMonThucTeTuHocColumn>
	{
	}
	
	#endregion ThucGiangMonThucTeTuHocFilter

	#region ThucGiangMonThucTeTuHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThucGiangMonThucTeTuHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThucGiangMonThucTeTuHocExpressionBuilder : SqlExpressionBuilder<ThucGiangMonThucTeTuHocColumn>
	{
	}
	
	#endregion ThucGiangMonThucTeTuHocExpressionBuilder	

	#region ThucGiangMonThucTeTuHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThucGiangMonThucTeTuHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThucGiangMonThucTeTuHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThucGiangMonThucTeTuHocProperty : ChildEntityProperty<ThucGiangMonThucTeTuHocChildEntityTypes>
	{
	}
	
	#endregion ThucGiangMonThucTeTuHocProperty
}

