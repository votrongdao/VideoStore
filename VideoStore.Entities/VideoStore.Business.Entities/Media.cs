//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace VideoStore.Business.Entities
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(User))]
    [KnownType(typeof(LikeMatching))]
    [KnownType(typeof(Recommendation))]
    public partial class Media: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'Id' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        private int _id;
    
        [DataMember]
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged("Title");
                }
            }
        }
        private string _title;
    
        [DataMember]
        public string Director
        {
            get { return _director; }
            set
            {
                if (_director != value)
                {
                    _director = value;
                    OnPropertyChanged("Director");
                }
            }
        }
        private string _director;
    
        [DataMember]
        public string Genre
        {
            get { return _genre; }
            set
            {
                if (_genre != value)
                {
                    _genre = value;
                    OnPropertyChanged("Genre");
                }
            }
        }
        private string _genre;
    
        [DataMember]
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPropertyChanged("Price");
                }
            }
        }
        private decimal _price;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<User> Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new TrackableCollection<User>();
                    _users.CollectionChanged += FixupUsers;
                }
                return _users;
            }
            set
            {
                if (!ReferenceEquals(_users, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_users != null)
                    {
                        _users.CollectionChanged -= FixupUsers;
                    }
                    _users = value;
                    if (_users != null)
                    {
                        _users.CollectionChanged += FixupUsers;
                    }
                    OnNavigationPropertyChanged("Users");
                }
            }
        }
        private TrackableCollection<User> _users;
    
        [DataMember]
        public TrackableCollection<LikeMatching> LikeMatching
        {
            get
            {
                if (_likeMatching == null)
                {
                    _likeMatching = new TrackableCollection<LikeMatching>();
                    _likeMatching.CollectionChanged += FixupLikeMatching;
                }
                return _likeMatching;
            }
            set
            {
                if (!ReferenceEquals(_likeMatching, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_likeMatching != null)
                    {
                        _likeMatching.CollectionChanged -= FixupLikeMatching;
                    }
                    _likeMatching = value;
                    if (_likeMatching != null)
                    {
                        _likeMatching.CollectionChanged += FixupLikeMatching;
                    }
                    OnNavigationPropertyChanged("LikeMatching");
                }
            }
        }
        private TrackableCollection<LikeMatching> _likeMatching;
    
        [DataMember]
        public Recommendation Recommendation
        {
            get { return _recommendation; }
            set
            {
                if (!ReferenceEquals(_recommendation, value))
                {
                    var previousValue = _recommendation;
                    _recommendation = value;
                    FixupRecommendation(previousValue);
                    OnNavigationPropertyChanged("Recommendation");
                }
            }
        }
        private Recommendation _recommendation;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            Users.Clear();
            LikeMatching.Clear();
            Recommendation = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupRecommendation(Recommendation previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && ReferenceEquals(previousValue.Medium, this))
            {
                previousValue.Medium = null;
            }
    
            if (Recommendation != null)
            {
                Recommendation.Medium = this;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Recommendation")
                    && (ChangeTracker.OriginalValues["Recommendation"] == Recommendation))
                {
                    ChangeTracker.OriginalValues.Remove("Recommendation");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Recommendation", previousValue);
                }
                if (Recommendation != null && !Recommendation.ChangeTracker.ChangeTrackingEnabled)
                {
                    Recommendation.StartTracking();
                }
            }
        }
    
        private void FixupUsers(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (User item in e.NewItems)
                {
                    if (!item.Medium.Contains(this))
                    {
                        item.Medium.Add(this);
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("Users", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (User item in e.OldItems)
                {
                    if (item.Medium.Contains(this))
                    {
                        item.Medium.Remove(this);
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Users", item);
                    }
                }
            }
        }
    
        private void FixupLikeMatching(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (LikeMatching item in e.NewItems)
                {
                    item.Medium = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("LikeMatching", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (LikeMatching item in e.OldItems)
                {
                    if (ReferenceEquals(item.Medium, this))
                    {
                        item.Medium = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("LikeMatching", item);
                    }
                }
            }
        }

        #endregion
    }
}
