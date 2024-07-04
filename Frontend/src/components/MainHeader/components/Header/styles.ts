import styled from 'styled-components';

export const Container = styled.div`
  display: flex;
  align-items: center;
  justify-content: space-between;
  background-color: ${(props) => props.theme.colors.darker};
  padding: 10px 20px;
  width: 100%;

  height: 30px;
`;

export const BoxItem = styled.div`
  display: flex;
  gap: 20px;
  color: #fff;
  font-size: 11px;

  button {
    background: transparent;
    border: none !important;
    outline: 0px auto -webkit-focus-ring-color;
  }
`;

export const SocialContainer = styled.div`
  display: flex;
  color: #fff;

  button {
    width: 40px;
  }
`;
