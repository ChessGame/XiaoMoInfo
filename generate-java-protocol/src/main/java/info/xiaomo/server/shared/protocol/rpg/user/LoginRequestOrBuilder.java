// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: UserMessage.proto

package info.xiaomo.server.shared.protocol.rpg.user;

public interface LoginRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:LoginRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <code>int32 sex = 1;</code>
   * @return The sex.
   */
  int getSex();

  /**
   * <code>int64 userId = 2;</code>
   * @return The userId.
   */
  long getUserId();

  /**
   * <code>string loginName = 3;</code>
   * @return The loginName.
   */
  java.lang.String getLoginName();
  /**
   * <code>string loginName = 3;</code>
   * @return The bytes for loginName.
   */
  com.google.protobuf.ByteString
      getLoginNameBytes();
}