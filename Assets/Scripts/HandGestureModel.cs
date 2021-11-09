using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime.Serialization;

[RealtimeModel]
public partial class HandGestureModel {
    // Five hand animator params required to set the hand gesture
    // All set to non-reliable (UDP) because of the frequency of events
    // and the unimportance of hand animations being perfect.
    [RealtimeProperty(1, false, true)]
    private int _handPoseId;
    [RealtimeProperty(2, false, true)]
    private float _flex;
    [RealtimeProperty(3, false, true)]
    private float _point;
    [RealtimeProperty(4, false, true)]
    private float _thumbsUp;
    [RealtimeProperty(5, false, true)]
    private float _pinch;
}

/* ----- Begin Normal Autogenerated Code ----- */
public partial class HandGestureModel : RealtimeModel {
    public int handPoseId {
        get {
            return _handPoseIdProperty.value;
        }
        set {
            if (_handPoseIdProperty.value == value) return;
            _handPoseIdProperty.value = value;
            InvalidateUnreliableLength();
            FireHandPoseIdDidChange(value);
        }
    }
    
    public float flex {
        get {
            return _flexProperty.value;
        }
        set {
            if (_flexProperty.value == value) return;
            _flexProperty.value = value;
            InvalidateUnreliableLength();
            FireFlexDidChange(value);
        }
    }
    
    public float point {
        get {
            return _pointProperty.value;
        }
        set {
            if (_pointProperty.value == value) return;
            _pointProperty.value = value;
            InvalidateUnreliableLength();
            FirePointDidChange(value);
        }
    }
    
    public float thumbsUp {
        get {
            return _thumbsUpProperty.value;
        }
        set {
            if (_thumbsUpProperty.value == value) return;
            _thumbsUpProperty.value = value;
            InvalidateUnreliableLength();
            FireThumbsUpDidChange(value);
        }
    }
    
    public float pinch {
        get {
            return _pinchProperty.value;
        }
        set {
            if (_pinchProperty.value == value) return;
            _pinchProperty.value = value;
            InvalidateUnreliableLength();
            FirePinchDidChange(value);
        }
    }
    
    public delegate void PropertyChangedHandler<in T>(HandGestureModel model, T value);
    public event PropertyChangedHandler<int> handPoseIdDidChange;
    public event PropertyChangedHandler<float> flexDidChange;
    public event PropertyChangedHandler<float> pointDidChange;
    public event PropertyChangedHandler<float> thumbsUpDidChange;
    public event PropertyChangedHandler<float> pinchDidChange;
    
    public enum PropertyID : uint {
        HandPoseId = 1,
        Flex = 2,
        Point = 3,
        ThumbsUp = 4,
        Pinch = 5,
    }
    
    #region Properties
    
    private UnreliableProperty<int> _handPoseIdProperty;
    
    private UnreliableProperty<float> _flexProperty;
    
    private UnreliableProperty<float> _pointProperty;
    
    private UnreliableProperty<float> _thumbsUpProperty;
    
    private UnreliableProperty<float> _pinchProperty;
    
    #endregion
    
    public HandGestureModel() : base(null) {
        _handPoseIdProperty = new UnreliableProperty<int>(1, _handPoseId);
        _flexProperty = new UnreliableProperty<float>(2, _flex);
        _pointProperty = new UnreliableProperty<float>(3, _point);
        _thumbsUpProperty = new UnreliableProperty<float>(4, _thumbsUp);
        _pinchProperty = new UnreliableProperty<float>(5, _pinch);
    }
    
    private void FireHandPoseIdDidChange(int value) {
        try {
            handPoseIdDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireFlexDidChange(float value) {
        try {
            flexDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FirePointDidChange(float value) {
        try {
            pointDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireThumbsUpDidChange(float value) {
        try {
            thumbsUpDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FirePinchDidChange(float value) {
        try {
            pinchDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    protected override int WriteLength(StreamContext context) {
        var length = 0;
        length += _handPoseIdProperty.WriteLength(context);
        length += _flexProperty.WriteLength(context);
        length += _pointProperty.WriteLength(context);
        length += _thumbsUpProperty.WriteLength(context);
        length += _pinchProperty.WriteLength(context);
        return length;
    }
    
    protected override void Write(WriteStream stream, StreamContext context) {
        var writes = false;
        writes |= _handPoseIdProperty.Write(stream, context);
        writes |= _flexProperty.Write(stream, context);
        writes |= _pointProperty.Write(stream, context);
        writes |= _thumbsUpProperty.Write(stream, context);
        writes |= _pinchProperty.Write(stream, context);
        if (writes) InvalidateContextLength(context);
    }
    
    protected override void Read(ReadStream stream, StreamContext context) {
        var anyPropertiesChanged = false;
        while (stream.ReadNextPropertyID(out uint propertyID)) {
            var changed = false;
            switch (propertyID) {
                case (uint) PropertyID.HandPoseId: {
                    changed = _handPoseIdProperty.Read(stream, context);
                    if (changed) FireHandPoseIdDidChange(handPoseId);
                    break;
                }
                case (uint) PropertyID.Flex: {
                    changed = _flexProperty.Read(stream, context);
                    if (changed) FireFlexDidChange(flex);
                    break;
                }
                case (uint) PropertyID.Point: {
                    changed = _pointProperty.Read(stream, context);
                    if (changed) FirePointDidChange(point);
                    break;
                }
                case (uint) PropertyID.ThumbsUp: {
                    changed = _thumbsUpProperty.Read(stream, context);
                    if (changed) FireThumbsUpDidChange(thumbsUp);
                    break;
                }
                case (uint) PropertyID.Pinch: {
                    changed = _pinchProperty.Read(stream, context);
                    if (changed) FirePinchDidChange(pinch);
                    break;
                }
                default: {
                    stream.SkipProperty();
                    break;
                }
            }
            anyPropertiesChanged |= changed;
        }
        if (anyPropertiesChanged) {
            UpdateBackingFields();
        }
    }
    
    private void UpdateBackingFields() {
        _handPoseId = handPoseId;
        _flex = flex;
        _point = point;
        _thumbsUp = thumbsUp;
        _pinch = pinch;
    }
    
}
/* ----- End Normal Autogenerated Code ----- */
