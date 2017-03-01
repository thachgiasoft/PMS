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
	/// Represents the DataRepository.KcqKhoiLuongGiangDayDoAnTotNghiepProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner))]
	public class KcqKhoiLuongGiangDayDoAnTotNghiepDataSource : ProviderDataSource<KcqKhoiLuongGiangDayDoAnTotNghiep, KcqKhoiLuongGiangDayDoAnTotNghiepKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnTotNghiepDataSource class.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnTotNghiepDataSource() : base(new KcqKhoiLuongGiangDayDoAnTotNghiepService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceView used by the KcqKhoiLuongGiangDayDoAnTotNghiepDataSource.
		/// </summary>
		protected KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceView KcqKhoiLuongGiangDayDoAnTotNghiepView
		{
			get { return ( View as KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqKhoiLuongGiangDayDoAnTotNghiepDataSource control invokes to retrieve data.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod SelectMethod
		{
			get
			{
				KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod selectMethod = KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceView class that is to be
		/// used by the KcqKhoiLuongGiangDayDoAnTotNghiepDataSource.
		/// </summary>
		/// <returns>An instance of the KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqKhoiLuongGiangDayDoAnTotNghiep, KcqKhoiLuongGiangDayDoAnTotNghiepKey> GetNewDataSourceView()
		{
			return new KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqKhoiLuongGiangDayDoAnTotNghiepDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceView : ProviderDataSourceView<KcqKhoiLuongGiangDayDoAnTotNghiep, KcqKhoiLuongGiangDayDoAnTotNghiepKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqKhoiLuongGiangDayDoAnTotNghiepDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceView(KcqKhoiLuongGiangDayDoAnTotNghiepDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqKhoiLuongGiangDayDoAnTotNghiepDataSource KcqKhoiLuongGiangDayDoAnTotNghiepOwner
		{
			get { return Owner as KcqKhoiLuongGiangDayDoAnTotNghiepDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod SelectMethod
		{
			get { return KcqKhoiLuongGiangDayDoAnTotNghiepOwner.SelectMethod; }
			set { KcqKhoiLuongGiangDayDoAnTotNghiepOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqKhoiLuongGiangDayDoAnTotNghiepService KcqKhoiLuongGiangDayDoAnTotNghiepProvider
		{
			get { return Provider as KcqKhoiLuongGiangDayDoAnTotNghiepService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqKhoiLuongGiangDayDoAnTotNghiep> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqKhoiLuongGiangDayDoAnTotNghiep> results = null;
			KcqKhoiLuongGiangDayDoAnTotNghiep item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod.Get:
					KcqKhoiLuongGiangDayDoAnTotNghiepKey entityKey  = new KcqKhoiLuongGiangDayDoAnTotNghiepKey();
					entityKey.Load(values);
					item = KcqKhoiLuongGiangDayDoAnTotNghiepProvider.Get(entityKey);
					results = new TList<KcqKhoiLuongGiangDayDoAnTotNghiep>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod.GetAll:
                    results = KcqKhoiLuongGiangDayDoAnTotNghiepProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod.GetPaged:
					results = KcqKhoiLuongGiangDayDoAnTotNghiepProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqKhoiLuongGiangDayDoAnTotNghiepProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqKhoiLuongGiangDayDoAnTotNghiepProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqKhoiLuongGiangDayDoAnTotNghiepProvider.GetById(_id);
					results = new TList<KcqKhoiLuongGiangDayDoAnTotNghiep>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
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
			if ( SelectMethod == KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod.Get || SelectMethod == KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod.GetById )
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
				KcqKhoiLuongGiangDayDoAnTotNghiep entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqKhoiLuongGiangDayDoAnTotNghiepProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqKhoiLuongGiangDayDoAnTotNghiep> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqKhoiLuongGiangDayDoAnTotNghiepProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqKhoiLuongGiangDayDoAnTotNghiepDataSource class.
	/// </summary>
	public class KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner : ProviderDataSourceDesigner<KcqKhoiLuongGiangDayDoAnTotNghiep, KcqKhoiLuongGiangDayDoAnTotNghiepKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner class.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod SelectMethod
		{
			get { return ((KcqKhoiLuongGiangDayDoAnTotNghiepDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceActionList

	/// <summary>
	/// Supports the KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner class.
	/// </summary>
	internal class KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceActionList : DesignerActionList
	{
		private KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceActionList(KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod SelectMethod
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

	#endregion KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceActionList
	
	#endregion KcqKhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner
	
	#region KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqKhoiLuongGiangDayDoAnTotNghiepDataSource.SelectMethod property.
	/// </summary>
	public enum KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod
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
		/// Represents the GetById method.
		/// </summary>
		GetById
	}
	
	#endregion KcqKhoiLuongGiangDayDoAnTotNghiepSelectMethod

	#region KcqKhoiLuongGiangDayDoAnTotNghiepFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayDoAnTotNghiepFilter : SqlFilter<KcqKhoiLuongGiangDayDoAnTotNghiepColumn>
	{
	}
	
	#endregion KcqKhoiLuongGiangDayDoAnTotNghiepFilter

	#region KcqKhoiLuongGiangDayDoAnTotNghiepExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayDoAnTotNghiepExpressionBuilder : SqlExpressionBuilder<KcqKhoiLuongGiangDayDoAnTotNghiepColumn>
	{
	}
	
	#endregion KcqKhoiLuongGiangDayDoAnTotNghiepExpressionBuilder	

	#region KcqKhoiLuongGiangDayDoAnTotNghiepProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqKhoiLuongGiangDayDoAnTotNghiepChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayDoAnTotNghiepProperty : ChildEntityProperty<KcqKhoiLuongGiangDayDoAnTotNghiepChildEntityTypes>
	{
	}
	
	#endregion KcqKhoiLuongGiangDayDoAnTotNghiepProperty
}

