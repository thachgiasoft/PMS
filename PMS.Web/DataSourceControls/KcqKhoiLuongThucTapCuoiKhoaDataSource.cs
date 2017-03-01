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
	/// Represents the DataRepository.KcqKhoiLuongThucTapCuoiKhoaProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqKhoiLuongThucTapCuoiKhoaDataSourceDesigner))]
	public class KcqKhoiLuongThucTapCuoiKhoaDataSource : ProviderDataSource<KcqKhoiLuongThucTapCuoiKhoa, KcqKhoiLuongThucTapCuoiKhoaKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongThucTapCuoiKhoaDataSource class.
		/// </summary>
		public KcqKhoiLuongThucTapCuoiKhoaDataSource() : base(new KcqKhoiLuongThucTapCuoiKhoaService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqKhoiLuongThucTapCuoiKhoaDataSourceView used by the KcqKhoiLuongThucTapCuoiKhoaDataSource.
		/// </summary>
		protected KcqKhoiLuongThucTapCuoiKhoaDataSourceView KcqKhoiLuongThucTapCuoiKhoaView
		{
			get { return ( View as KcqKhoiLuongThucTapCuoiKhoaDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqKhoiLuongThucTapCuoiKhoaDataSource control invokes to retrieve data.
		/// </summary>
		public KcqKhoiLuongThucTapCuoiKhoaSelectMethod SelectMethod
		{
			get
			{
				KcqKhoiLuongThucTapCuoiKhoaSelectMethod selectMethod = KcqKhoiLuongThucTapCuoiKhoaSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqKhoiLuongThucTapCuoiKhoaSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqKhoiLuongThucTapCuoiKhoaDataSourceView class that is to be
		/// used by the KcqKhoiLuongThucTapCuoiKhoaDataSource.
		/// </summary>
		/// <returns>An instance of the KcqKhoiLuongThucTapCuoiKhoaDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqKhoiLuongThucTapCuoiKhoa, KcqKhoiLuongThucTapCuoiKhoaKey> GetNewDataSourceView()
		{
			return new KcqKhoiLuongThucTapCuoiKhoaDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqKhoiLuongThucTapCuoiKhoaDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqKhoiLuongThucTapCuoiKhoaDataSourceView : ProviderDataSourceView<KcqKhoiLuongThucTapCuoiKhoa, KcqKhoiLuongThucTapCuoiKhoaKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongThucTapCuoiKhoaDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqKhoiLuongThucTapCuoiKhoaDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqKhoiLuongThucTapCuoiKhoaDataSourceView(KcqKhoiLuongThucTapCuoiKhoaDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqKhoiLuongThucTapCuoiKhoaDataSource KcqKhoiLuongThucTapCuoiKhoaOwner
		{
			get { return Owner as KcqKhoiLuongThucTapCuoiKhoaDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqKhoiLuongThucTapCuoiKhoaSelectMethod SelectMethod
		{
			get { return KcqKhoiLuongThucTapCuoiKhoaOwner.SelectMethod; }
			set { KcqKhoiLuongThucTapCuoiKhoaOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqKhoiLuongThucTapCuoiKhoaService KcqKhoiLuongThucTapCuoiKhoaProvider
		{
			get { return Provider as KcqKhoiLuongThucTapCuoiKhoaService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqKhoiLuongThucTapCuoiKhoa> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqKhoiLuongThucTapCuoiKhoa> results = null;
			KcqKhoiLuongThucTapCuoiKhoa item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KcqKhoiLuongThucTapCuoiKhoaSelectMethod.Get:
					KcqKhoiLuongThucTapCuoiKhoaKey entityKey  = new KcqKhoiLuongThucTapCuoiKhoaKey();
					entityKey.Load(values);
					item = KcqKhoiLuongThucTapCuoiKhoaProvider.Get(entityKey);
					results = new TList<KcqKhoiLuongThucTapCuoiKhoa>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqKhoiLuongThucTapCuoiKhoaSelectMethod.GetAll:
                    results = KcqKhoiLuongThucTapCuoiKhoaProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqKhoiLuongThucTapCuoiKhoaSelectMethod.GetPaged:
					results = KcqKhoiLuongThucTapCuoiKhoaProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqKhoiLuongThucTapCuoiKhoaSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqKhoiLuongThucTapCuoiKhoaProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqKhoiLuongThucTapCuoiKhoaProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqKhoiLuongThucTapCuoiKhoaSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqKhoiLuongThucTapCuoiKhoaProvider.GetById(_id);
					results = new TList<KcqKhoiLuongThucTapCuoiKhoa>();
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
			if ( SelectMethod == KcqKhoiLuongThucTapCuoiKhoaSelectMethod.Get || SelectMethod == KcqKhoiLuongThucTapCuoiKhoaSelectMethod.GetById )
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
				KcqKhoiLuongThucTapCuoiKhoa entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqKhoiLuongThucTapCuoiKhoaProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqKhoiLuongThucTapCuoiKhoa> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqKhoiLuongThucTapCuoiKhoaProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqKhoiLuongThucTapCuoiKhoaDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqKhoiLuongThucTapCuoiKhoaDataSource class.
	/// </summary>
	public class KcqKhoiLuongThucTapCuoiKhoaDataSourceDesigner : ProviderDataSourceDesigner<KcqKhoiLuongThucTapCuoiKhoa, KcqKhoiLuongThucTapCuoiKhoaKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongThucTapCuoiKhoaDataSourceDesigner class.
		/// </summary>
		public KcqKhoiLuongThucTapCuoiKhoaDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoiLuongThucTapCuoiKhoaSelectMethod SelectMethod
		{
			get { return ((KcqKhoiLuongThucTapCuoiKhoaDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqKhoiLuongThucTapCuoiKhoaDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqKhoiLuongThucTapCuoiKhoaDataSourceActionList

	/// <summary>
	/// Supports the KcqKhoiLuongThucTapCuoiKhoaDataSourceDesigner class.
	/// </summary>
	internal class KcqKhoiLuongThucTapCuoiKhoaDataSourceActionList : DesignerActionList
	{
		private KcqKhoiLuongThucTapCuoiKhoaDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongThucTapCuoiKhoaDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqKhoiLuongThucTapCuoiKhoaDataSourceActionList(KcqKhoiLuongThucTapCuoiKhoaDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoiLuongThucTapCuoiKhoaSelectMethod SelectMethod
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

	#endregion KcqKhoiLuongThucTapCuoiKhoaDataSourceActionList
	
	#endregion KcqKhoiLuongThucTapCuoiKhoaDataSourceDesigner
	
	#region KcqKhoiLuongThucTapCuoiKhoaSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqKhoiLuongThucTapCuoiKhoaDataSource.SelectMethod property.
	/// </summary>
	public enum KcqKhoiLuongThucTapCuoiKhoaSelectMethod
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
	
	#endregion KcqKhoiLuongThucTapCuoiKhoaSelectMethod

	#region KcqKhoiLuongThucTapCuoiKhoaFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongThucTapCuoiKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongThucTapCuoiKhoaFilter : SqlFilter<KcqKhoiLuongThucTapCuoiKhoaColumn>
	{
	}
	
	#endregion KcqKhoiLuongThucTapCuoiKhoaFilter

	#region KcqKhoiLuongThucTapCuoiKhoaExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongThucTapCuoiKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongThucTapCuoiKhoaExpressionBuilder : SqlExpressionBuilder<KcqKhoiLuongThucTapCuoiKhoaColumn>
	{
	}
	
	#endregion KcqKhoiLuongThucTapCuoiKhoaExpressionBuilder	

	#region KcqKhoiLuongThucTapCuoiKhoaProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqKhoiLuongThucTapCuoiKhoaChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongThucTapCuoiKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongThucTapCuoiKhoaProperty : ChildEntityProperty<KcqKhoiLuongThucTapCuoiKhoaChildEntityTypes>
	{
	}
	
	#endregion KcqKhoiLuongThucTapCuoiKhoaProperty
}

